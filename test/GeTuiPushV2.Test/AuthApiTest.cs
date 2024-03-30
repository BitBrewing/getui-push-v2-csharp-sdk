using GeTuiPushV2.Apis;
using GeTuiPushV2.Apis.Dtos;
using Newtonsoft.Json;

namespace GeTuiPushV2.Test
{
    public class AuthApiTest
    {
        private readonly IAuthApi _authApi;

        public AuthApiTest(IAuthApi authApi)
        {
            _authApi = authApi;
        }

        [Fact]
        public async Task RevokeTokenAsync()
        {
            var result = await _authApi.RevokeTokenAsync("xxx");
            Assert.Equal(10001, result.Code);
        }
    }
}