using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Utilities
{
    internal class LoggerHandler
    {
        private readonly ILogger _logger;
        public LoggerHandler(ILogger<LoggerHandler> logger)
        {
            _logger = logger;
        }
        public void LogError(string message,Exception exception)
        {
            _logger.LogError(exception,message);
        }

        public void LogInfo(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
