using System;
using System.Configuration;

namespace Astra.EmailPriceChecker.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var app = new App();

                app.Start();

                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error {0}", e.Message);
                System.Console.ReadKey();
            }
        }
    }

    public class App
    {
        private readonly EmailPriceChecker _emailPriceChecker;

        public App()
        {
            //var logger = new Logger.Logger(ConfigurationManager.AppSettings["LogPath"]);
            var logger = new Logger.Logger();
            var emailUri = ConfigurationManager.AppSettings["emailUri"];
            var emailAccount = ConfigurationManager.AppSettings["emailAccount"];
            var emailAccountPassword = ConfigurationManager.AppSettings["emailAccountPassword"];
            var mailBox = ConfigurationManager.AppSettings["mailBox"];
            var interval = ConfigurationManager.AppSettings["TimerInterval"];
            var bwicMonitorId = ConfigurationManager.AppSettings["BwicMonitorRunner"];

            var service = new ExchangeService.ExchangeService(emailAccount, emailAccountPassword, emailUri);
            //_emailPriceChecker = new EmailPriceChecker(service, mailBox, Convert.ToInt32(interval), logger, Convert.ToInt32(bwicMonitorId));
            _emailPriceChecker = new EmailPriceChecker(service, mailBox, Convert.ToInt32(interval), Convert.ToInt32(bwicMonitorId));
        }

        public void Start()
        {
            _emailPriceChecker.StartListening();
        }
    }
}