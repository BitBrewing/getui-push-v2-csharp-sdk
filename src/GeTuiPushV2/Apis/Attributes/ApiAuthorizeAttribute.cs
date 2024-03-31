using System;
using System.Text;
using System.Threading.Tasks;
using GeTuiPushV2.Services;
using Microsoft.Extensions.DependencyInjection;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace GeTuiPushV2.Apis.Attributes
{
	internal class ApiAuthorizeAttribute: ApiActionAttribute
    {
        public override async Task OnRequestAsync(ApiRequestContext context)
        {
            var tokenService = context.HttpContext.ServiceProvider.GetRequiredService<AuthTokenService>();

            var token = await tokenService.GetAccessTokenAsync();
            context.HttpContext.RequestMessage.Headers.TryAddWithoutValidation("token", token);
        }
    }
}

