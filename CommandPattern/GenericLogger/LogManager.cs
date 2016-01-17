using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.GenericLogger
{
    public class LogManager
    {
        ILogger logger;

        public LogManager(ILogger _logger)
        {
            logger = _logger;
        }

        public void Log(string message)
        {
            logger.Log(message);
        }
    }
}
