using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;

namespace Astra.EmailPriceChecker.EmailManager
{
    public class EmailManager
    {
        private readonly SmtpClient _client;
        private MailMessage _message;
        private readonly Logger.Logger _logger;
        private readonly string _messageSubject;
        
        //old code before implementing log4net
        //public EmailManager(Logger.Logger logger)
        //{
        //    _client = new SmtpClient();
        //    _logger = logger;
        //    _messageSubject = ConfigurationManager.AppSettings["BwicEmailSubject"];

        //}

        public EmailManager()
        {
            _client = new SmtpClient();
            //_logger = logger;
            _logger = new Logger.Logger();
            _messageSubject = ConfigurationManager.AppSettings["BwicEmailSubject"];

        }

        public void SendErrorEmail(Exception exception)
        {
            try
            {
                _message = new MailMessage
                {
                    Body = $"{exception.Message}{Environment.NewLine}{exception.StackTrace}",
                    Subject = "Error With Email Price Checker"
                };

                _message.To.Add("sunil.bhaskar@astra-amco.com");
                //_message.To.Add("claudia.cojocaru@astra-amco.com");

                _client.Send(_message);
            }
            catch(Exception ex)
            {
                _logger.Error("error sending the error email", ex);
            }
        }

        public void SendNotificationEmail(string body, IEnumerable<string> users)
        {
            try
            {
                _logger.WriteToLog("Sending Email");

                _message = new MailMessage { Body = body, Subject = _messageSubject };

                foreach (var user in users)
                {
                    _message.To.Add(user);
                }

                _client.Send(_message);

                _logger.WriteToLog("email sents");
            }
            catch(Exception ex)
            {
                _logger.Error("error sending the notificaiton emails", ex);
            }
        }
    }
}