using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ORM.Utilities
{
    public class OperationHandler
    {
        private readonly ILogger<OperationHandler> _logger;
        f
        public OperationHandler(ILogger<OperationHandler> logger)
        {
            _logger = logger;
        }

        private static void OperationHandler(Action action)
        {

            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                // Log bilgileri hazırlanıyor
                var logData = new LogData
                {
                    Timestamp = DateTime.UtcNow,
                    Exception = ex,
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    AdditionalData = new Dictionary<string, object>
            {
                {"ActionName", action.Method.Name},
                {"Parameters", action.Method.GetParameters().Select(p => $"{p.Name}: {p.ParameterType}").ToList()}
            }
                };

                // Log dosyasına yazılıyor
                logger.LogError(JsonConvert.SerializeObject(logData, Formatting.Indented));

                // Exception fırlatılıyor
                throw;
            }
        }

    }
    public class LogData
    {
        public DateTime Timestamp { get; set; }
        public Exception Exception { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public Dictionary<string, object> AdditionalData { get; set; }
    }
}
