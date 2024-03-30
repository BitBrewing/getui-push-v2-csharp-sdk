using Newtonsoft.Json;
using System;

namespace GeTuiPushV2.Apis.Dtos
{
	public class AuthToken
	{
        /// <summary>
        /// token过期时间，ms时间戳
        /// </summary>
        [JsonProperty("expire_time")]
		public long ExpireTime { get; set; }

        /// <summary>
        /// 接口调用凭据
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

