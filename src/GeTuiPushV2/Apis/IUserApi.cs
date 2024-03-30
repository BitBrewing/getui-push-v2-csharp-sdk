using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using GeTuiPushV2.Apis.Attributes;
using GeTuiPushV2.Apis.Dtos;
using WebApiClientCore.Attributes;

namespace GeTuiPushV2.Apis
{
    /// <summary>
    /// 用户API
    /// <para>https://docs.getui.com/getui/server/rest_v2/user/</para>
    /// </summary>
    [ApiAuthorize]
    [JsonNetReturn(EnsureSuccessStatusCode = false)]
    public interface IUserApi
    {
        /// <summary>
        /// 绑定别名
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>一个cid只能绑定一个别名，若已绑定过别名的cid再次绑定新别名，则前一个别名会自动解绑，并绑定新别名。</remarks>
        [HttpPost("user/alias")]
        Task<BaseResult> UserAliasAsync([JsonNetContent] UserAliasInput input, CancellationToken cancellationToken = default);
    }
}