using System;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace GeTuiPushV2.Logging
{
	public interface IGeTuiPushLogger
	{
        Task WriteLogAsync(ApiResponseContext context, LogMessage logMessage);
    }
}

