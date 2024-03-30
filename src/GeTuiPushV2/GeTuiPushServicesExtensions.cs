using GeTuiPushV2;
using GeTuiPushV2.Apis;
using GeTuiPushV2.Internal;
using GeTuiPushV2.Logging;
using GeTuiPushV2.Options;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using GeTuiPushV2.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class GeTuiPushServicesExtensions
    {
        public static IGeTuiPushBuilder AddGeTuiPush(this IServiceCollection services)
        {
            return services.AddGeTuiPush(_ => { });
        }

        public static IGeTuiPushBuilder AddGeTuiPush(this IServiceCollection services, Action<GeTuiPushOptions> configure)
        {
            services.Configure(configure);

            services.AddMemoryCache();
            services.AddSingleton<AuthTokenService>();

            services
                .AddConfiguredHttpApi<IAuthApi>()
                .AddConfiguredHttpApi<IPushApi>();

            return new GeTuiPushBuilder(services);
        }

        private static IServiceCollection AddConfiguredHttpApi<T>(this IServiceCollection services) where T : class
        {
            services
                .AddHttpApi<T>((apiOptions, provider) =>
                {
                    var options = provider.GetService<IOptions<GeTuiPushOptions>>().Value;

                    apiOptions.HttpHost = new Uri($"https://restapi.getui.com/v2/{options.AppId}/");

                    var logger = provider.GetService<GeTuiLoggerPushAdapter>();
                    if (logger != null)
                    {
                        apiOptions.UseLogging = true;
                        apiOptions.GlobalFilters.Add(logger);
                    }
                    else
                    {
                        apiOptions.UseLogging = false;
                    }
                })
                .ConfigureNewtonsoftJson(x =>
                {
                    //x.JsonSerializeOptions.Converters.Add(new JsonNameStringEnumConverter());
                    x.JsonSerializeOptions.NullValueHandling = NullValueHandling.Ignore;
                });

            return services;
        }
    }
}
