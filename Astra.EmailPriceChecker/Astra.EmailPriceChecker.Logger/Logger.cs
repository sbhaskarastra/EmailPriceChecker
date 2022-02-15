using System;
using System.IO;
using log4net;
namespace Astra.EmailPriceChecker.Logger
{
    public class Logger
    {
        //private readonly string _logPath;

        private readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //public Logger(string logPath)
        //{
        //    _logPath = logPath;
        //}

        public void WriteToLog(string line)
        {
            //using (var writer = new StreamWriter(_logPath, true))
            //{
            //    writer.WriteLine("[{0:yyyy-MM-dd HH:mm:ss.fff}] {1}", DateTime.Now, line);
            //}

            //logger.Info(line);

            logger.Logger.Log(typeof(Astra.EmailPriceChecker.Logger.Logger), log4net.Core.Level.Info , line, null);
        }

        public void Error(string message, Exception ex)
        {
            //logger.Error(message, ex);
            logger.Logger.Log(typeof(Astra.EmailPriceChecker.Logger.Logger), log4net.Core.Level.Error, message, ex);
        }
    }
}
