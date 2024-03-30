using System;
using GeTuiPushV2;
using GeTuiPushV2.Logging;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class GeTuiPushBuilderExtensions
	{
        /// <summary>
        /// 添加默认的日志
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IGeTuiPushBuilder AddDefaultLogger(this IGeTuiPushBuilder builder)
        {
            // 默认日志由 WebApiClientCore 负责输出
            builder.Services.TryAddSingleton<GeTuiLoggerPushAdapter>();
            return builder;
        }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IGeTuiPushBuilder AddLogger<T>(this IGeTuiPushBuilder builder) where T : class, IGeTuiPushLogger
        {
            builder.Services.AddSingleton<IGeTuiPushLogger, T>();
            builder.Services.TryAddSingleton<GeTuiLoggerPushAdapter>();

            return builder;
        }
    }
}

