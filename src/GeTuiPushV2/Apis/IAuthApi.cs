using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GeTuiPushV2.Apis.Dtos;
using WebApiClientCore.Attributes;

namespace GeTuiPushV2.Apis
{
    /// <summary>
    /// 鉴权API
    /// <para>https://docs.getui.com/getui/server/rest_v2/token/</para>
    /// </summary>
    /// <remarks>
    /// <para>token是个推开放平台全局唯一接口调用凭据，访问所有接口都需要此凭据，开发者需要妥善保管。</para>
    /// <para>token的有效期截止时间通过接口返回参数expire_time来标识，目前是接口调用时间+1天的毫秒时间戳。</para>
    /// <para>token过期后无法使用，开发者需要定时刷新。为保证高可用，建议开发者在定时刷新的同时做被动刷新，即当调用业务接口返回错误码10001时调用获取token被动刷新</para>
    /// </remarks>
    [JsonNetReturn(EnsureSuccessStatusCode = false)]
    public interface IAuthApi
    {
        /// <summary>
        /// 获取鉴权token
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("auth")]
        Task<AuthCreateTokenResult> CreateTokenAsync([JsonNetContent]AuthCreateTokenInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 删除鉴权token
        /// </summary>
        /// <param name="token">接口调用凭证</param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// 为防止token被滥用或泄露，开发者可以调用此接口主动使token失效
        /// </remarks>
        /// <returns></returns>
        [HttpDelete("auth/{token}")]
        Task<BaseResult> RevokeTokenAsync([Required]string token, CancellationToken cancellationToken = default);
    }
}
