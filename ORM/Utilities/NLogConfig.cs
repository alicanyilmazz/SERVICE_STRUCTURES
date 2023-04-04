using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Utilities
{
    public static class NLogConfig
    {
        private static readonly IConfigurationRoot _config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        public static readonly IServiceProvider _serviceProvider;
        public static void BuildLogConfig()
        {
            using var _serviceProvider = new ServiceCollection()
            .AddTransient<LoggerHandler>() // Runner is the custom class
          .AddLogging(loggingBuilder =>
          {
              // configure Logging with NLog
              loggingBuilder.ClearProviders();
              loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
              loggingBuilder.AddNLog(_config);
          }).BuildServiceProvider();
        }
    }
}
