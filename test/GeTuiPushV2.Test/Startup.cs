using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.DependencyInjection.Logging;
using Xunit.DependencyInjection;
using GeTuiPushV2.Test;
using GeTuiPushV2.Logging;
using WebApiClientCore.Attributes;
using WebApiClientCore;

namespace GeTuiPushV2.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddGeTuiPush(x =>
                {
                    x.AppId = "AppId";
                    x.AppKey = "AppKey";
                    x.MasterSecret = "MasterSecret";
                })
                .AddLogger<OutputLogger>();
        }

        public void Configure(ILoggerFactory loggerFactory, ITestOutputHelperAccessor accessor)
        {
            loggerFactory.AddProvider(new XunitTestOutputLoggerProvider(accessor));
        }

        private class OutputLogger : IGeTuiPushLogger
        {
            private readonly ILogger<OutputLogger> _logger;

            public OutputLogger(ILogger<OutputLogger> logger)
            {
                _logger = logger;
            }

            public Task WriteLogAsync(ApiResponseContext context, LogMessage logMessage)
            {
                _logger.LogInformation("[Request]\r\n{RequestHeaders}\r\n{RequestContent}\r\n\r\n[Response]\r\n{ResponseHeaders}\r\n{ResponseContent}\r\n\r\n[Elapsed]\r\n{Elapsed}",
                    logMessage.RequestHeaders,
                    logMessage.RequestContent,
                    logMessage.ResponseHeaders,
                    logMessage.ResponseContent,
                    logMessage.ResponseTime - logMessage.RequestTime);

                return Task.CompletedTask;
            }
        }
    }
}
