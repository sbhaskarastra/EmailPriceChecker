using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Astra.EmailPriceChecker.Data;
using Astra.EmailPriceChecker.Mail;
using Microsoft.Exchange.WebServices.Data;

namespace Astra.EmailPriceChecker
{
    public class EmailPriceChecker
    {
        private readonly Timer _authenticationTimer;
        private readonly DataRepository _dataRepository;
        private readonly EmailManager.EmailManager _emailManager;
        private readonly Logger.Logger _logger;
        private readonly string _mailBox;
        private readonly ExchangeService.ExchangeService _service;
        private readonly Timer _timer;
        private List<EmailReport> _emailReportList;
        private bool _running;
        private IEnumerable<string> _watchList;

        private const int BwicMonitorEmailId = 20;
        private readonly int _bwicMonitorId;
        public EmailPriceChecker(ExchangeService.ExchangeService service, string mailBox, int timerInterval, int bwicMonitorId)
        {
            _service = service;
            _mailBox = mailBox;
            _running = false;
            //_logger = logger; old code before implementing log4net
            _logger = new Logger.Logger();
            _bwicMonitorId = bwicMonitorId;
            //_emailManager = new EmailManager.EmailManager(logger);old code before implementing log4net
            _emailManager = new EmailManager.EmailManager();

            _timer = new Timer(timerInterval);
            //_authenticationTimer = new Timer(86400000); //60 * 60 * 24 every day.
            _authenticationTimer = new Timer(3300000); //60 * 55.
            _timer.Elapsed += _timer_Elapsed;

            _authenticationTimer.Elapsed += AuthenticationTimerElapsed;
            _dataRepository = new DataRepository();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //_logger.WriteToLog($"Searching for new emails");
            _watchList = _dataRepository.GetWatchListItems(_bwicMonitorId);
            _emailReportList = new List<EmailReport>();
            //_logger.WriteToLog($"Searching for new emails");
            CheckForNewMailItem();
        }

        private void AuthenticationTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _service.Authenticate();
            try
            {
                _service.AddSubscription(_mailBox);
            }
            catch(Exception ex)
            {
                _logger.Error("looks like an error while adding subscription during authentication", ex);
                _emailManager.SendErrorEmail(ex);
                _running = false;
            }
            
        }

        public void StartListening()
        {
            try
            {
                _service.Authenticate();
                _service.AddSubscription(_mailBox);
                
                ////need to remove this//did for the testing purpose
                //_watchList = _dataRepository.GetWatchListItems(_bwicMonitorId);
                //_emailReportList = new List<EmailReport>();
                //_logger.WriteToLog($"Searching for new emails. {DateTime.Now:yyyy-MM-dd}");
                //CheckForNewMailItem();
                ////end
                
                _running = true;
                _timer.Start();
                _authenticationTimer.Start();
                _logger.WriteToLog("Started Timer");
            }
            catch (Exception ex)
            {
                _logger.Error("looks like an error while adding subscription when the service starts listening", ex);
                _emailManager.SendErrorEmail(ex);
                _running = false;
            }
        }

        public void StopListening()
        {
            _running = false;

            _timer.Stop();
            _authenticationTimer.Stop();
        }

        private void CheckForNewMailItem()
        {
            //_logger.WriteToLog("New Email Found start");

            var itemPropertySet = new PropertySet(BasePropertySet.FirstClassProperties)
            {
                RequestedBodyType = BodyType.Text
            };

            try
            {
                var subscriptions = _service.GetSubscriptions();

                foreach (var pullSubscription in subscriptions)
                foreach (var itemEvent in pullSubscription.GetEvents().ItemEvents)
                {
                    var item = Item.Bind(_service.GetService(), itemEvent.ItemId, itemPropertySet);
                    var newEmail = new MailItem
                    {
                        From = ((EmailAddress) item[EmailMessageSchema.From]).Address,
                        Recipients = ((EmailAddressCollection) item[EmailMessageSchema.ToRecipients])
                            .Select(recipient => recipient.Address).ToArray(),
                        Subject = item.Subject,
                        Body = item.Body.ToString(),
                        Lines = item.Body.ToString().Split('\r'),
                        DateReceived = item.DateTimeReceived
                    };
                    
                    _logger.WriteToLog("New Email Found");

                    NewEmailFound(newEmail);
                }
            }
            catch (Exception ex)
            {
                switch (ex.HResult)
                {
                    case -2146233088:
                        // do nothing
                        //_logger.Error("some error in checking new emails", ex);
                        break;
                    default:
                        _logger.Error("some error in checking new emails", ex);
                        _emailManager.SendErrorEmail(ex);
                        break;
                }
                
                // ignored
                //var x = ex;//Sunil Bhaskar: 30 Sep 2021: have no idea why this line was here
            }

            if (_emailReportList != null && _emailReportList.Count > 0)
            {
                _logger.WriteToLog("Sending Email");
                SendEmailReport(_emailReportList);
            }

            //_logger.WriteToLog("nothing found");
        }

        private void SendEmailReport(IEnumerable<EmailReport> emailReport)
        {
            var builder = new StringBuilder();
            foreach (var report in emailReport) builder.Append(report);

            var users = _dataRepository.GetBwicMonitorEmailDistributionListByEmailId(BwicMonitorEmailId);
            _emailManager.SendNotificationEmail(builder.ToString(), users);
        }

        private void NewEmailFound(MailItem email)
        {
            try
            {
                foreach (var keyWord in _watchList)
                    if (email.Subject.Contains(keyWord) || email.Body.Contains(keyWord) || email.From.Contains(keyWord))
                    {
                        _logger.WriteToLog($"Found word: {keyWord}");
                        var emailReport = ProcessEmail(email, keyWord);
                        if (emailReport != null)
                            _emailReportList.Add(emailReport);
                    }
            }
            catch (Exception ex)
            {
                _logger.Error("Email processing error", ex);
                _emailManager.SendErrorEmail(ex);
                _running = false;
                throw ex;
            }
        }

        private EmailReport ProcessEmail(MailItem email, string keyWord)
        {
            return GetEmailDetails(email, keyWord);
        }

        private EmailReport GetEmailDetails(MailItem email, string keyWord)
        {
            try
            {
                var emailReport = new EmailReport
                {
                    From = email.From,
                    EmailLine = new List<string>(),
                    Subject = email.Subject,
                    DateReceived = email.DateReceived
                };

                var lines = email.Lines.Where(m => m.Contains(keyWord)).ToList();

                foreach (var line in lines.Where(line => !DuplicateEntry(line))) emailReport.EmailLine.Add(line);

                if (email.Subject.Contains(keyWord)) emailReport.EmailLine.Add($"Email Subject: {email.Subject}.");

                if (email.From.Contains(keyWord)) emailReport.EmailLine.Add($"Email From: {email.From}.");

                if (emailReport.EmailLine.Count == 0)
                    return null;

                return emailReport;
            }
            catch(Exception ex)
            {
                _logger.Error("Error getemaildetails", ex);
                _emailManager.SendErrorEmail(ex);
            }

            return null;
        }

        //private bool DuplicateEntry(string line)
        //{
        //    string[] splitLine = null;
        //    if (line.Contains("\t"))
        //        splitLine = line.Split('\t');
        //    else
        //        splitLine = line.Split(' ');

        //    foreach (var emailReport in _emailReportList)
        //    {
        //        foreach (var lineItem in splitLine)
        //        {
        //            if (emailReport.EmailLine.Contains(line))
        //                return true;
        //        }
        //    }
        //    return false;
        //}

        private bool DuplicateEntry(string line)
        {
            return _emailReportList.SelectMany(emailReport => emailReport.EmailLine)
                .Any(emailLine => emailLine.Equals(line));
        }
    }
}