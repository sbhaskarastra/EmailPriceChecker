using System;
using System.Configuration;

namespace Astra.EmailPriceChecker.Service.Service
{
    public class ServiceRunner
    {
        private readonly EmailPriceChecker _emailPriceChecker;
        private readonly Logger.Logger _logger;
        public ServiceRunner()
        {
            //_logger = new Logger.Logger(ConfigurationManager.AppSettings["LogPath"]); old code before implementing log4net
            _logger = new Logger.Logger();
            var emailUri = ConfigurationManager.AppSettings["emailUri"];
            var emailAccount = ConfigurationManager.AppSettings["emailAccount"];
            var emailAccountPassword = ConfigurationManager.AppSettings["emailAccountPassword"];
            var mailBox = ConfigurationManager.AppSettings["mailBox"];
            var interval = ConfigurationManager.AppSettings["TimerInterval"];
            var bwicMonitorId = ConfigurationManager.AppSettings["BwicMonitorRunner"];
            
            var service = new ExchangeService.ExchangeService(emailAccount, emailAccountPassword, emailUri);
            //_emailPriceChecker = new EmailPriceChecker(service, mailBox, Convert.ToInt32(interval), _logger, Convert.ToInt32(bwicMonitorId));
            _emailPriceChecker = new EmailPriceChecker(service, mailBox, Convert.ToInt32(interval), Convert.ToInt32(bwicMonitorId));
        }

        public void StartService()
        {
            try
            {
                _logger.WriteToLog("service starting");

                _emailPriceChecker.StartListening();

                _logger.WriteToLog("started listening");
            }
            catch (Exception ex)
            {
                _logger.Error("error while starting the service", ex);

                //var manager = new EmailManager.EmailManager(_logger);
                var manager = new EmailManager.EmailManager();

                manager.SendErrorEmail(ex);
            }
        }

        public void StopService()
        {
            try
            {
                _logger.WriteToLog("service stopping now");
                _emailPriceChecker.StopListening();
                _logger.WriteToLog("service stopped");

            }
            catch (Exception ex)
            {
                _logger.Error("error while stopping the service", ex);
                //var manager = new EmailManager.EmailManager(_logger);
                var manager = new EmailManager.EmailManager();
                manager.SendErrorEmail(ex);
            }

        }
    }
}