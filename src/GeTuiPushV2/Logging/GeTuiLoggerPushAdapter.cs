using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace GeTuiPushV2.Logging
{
	internal class GeTuiLoggerPushAdapter: LoggingFilterAttribute
    {
        private readonly IEnumerable<IGeTuiPushLogger> _loggers;

        public GeTuiLoggerPushAdapter(IEnumerable<IGeTuiPushLogger> loggers)
        {
            _loggers = loggers;
        }

        protected override async Task WriteLogAsync(ApiResponseContext context, LogMessage logMessage)
        {
            foreach (var logger in _loggers)
            {
                await logger.WriteLogAsync(context, logMessage);
            }
        }
    }
}

