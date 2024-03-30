using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Internal
{
    internal class GeTuiPushBuilder: IGeTuiPushBuilder
    {
        public GeTuiPushBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
