using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace GeTuiPushV2
{
    public interface IGeTuiPushBuilder
    {
        IServiceCollection Services { get; }
    }
}
