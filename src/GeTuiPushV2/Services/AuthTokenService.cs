using GeTuiPushV2.Apis;
using GeTuiPushV2.Apis.Dtos;
using GeTuiPushV2.Options;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApiClientCore;

namespace GeTuiPushV2.Services
{
    internal class AuthTokenService
    {
        private readonly IAuthApi _authApi;
        private readonly IMemoryCache _memoryCache;
        private readonly IOptions<GeTuiPushOptions> _options;

        private readonly object _tokenKey = new();
        private readonly SemaphoreSlim _tokenLock = new(1);

        public AuthTokenService(IAuthApi authApi, IMemoryCache memoryCache, IOptions<GeTuiPushOptions> options)
        {
            _authApi = authApi;
            _memoryCache = memoryCache;
            _options = options;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            var token = _memoryCache.Get<AuthToken>(_tokenKey);
            if (token == null)
            {
                await _tokenLock.WaitAsync();

                try
                {
                    token = _memoryCache.Get<AuthToken>(_tokenKey);
                    if (token == null)
                    {
                        token = await GetAccessTokenCoreAsync();
                        _memoryCache.Set(_tokenKey, token, TimeSpan.FromMilliseconds(token.ExpireTime - 30000));
                    }
                }
                finally
                {
                    _tokenLock.Release();
                }
            }

            return token.Token;
        }

        private async Task<AuthToken> GetAccessTokenCoreAsync()
        {
            var timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            var input = new CreateTokenInput
            {
                AppKey = _options.Value.AppKey,
                Timestamp = timestamp,
                Sign = ComputeSha256Hash($"{_options.Value.AppKey}{timestamp}{_options.Value.MasterSecret}"),
            };
            var result = await _authApi.CreateTokenAsync(input).EnsureThrowErrorAsync();

            return result.Data;
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using SHA256 sha256Hash = SHA256.Create();

            var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            var builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
