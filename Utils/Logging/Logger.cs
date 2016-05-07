using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Logging
{
    public static class Logger
    {
        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        private static log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(Logger));

        public static void Log(string message)
        {
            _logger.Info(message);
        }

        public static void Log(string message, Exception ex)
        {
            _logger.Error(message, ex);
        }
    }
}
