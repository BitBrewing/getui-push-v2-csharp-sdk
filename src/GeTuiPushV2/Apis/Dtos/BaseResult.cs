using System;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
	public class BaseResult
	{
        /// <summary>
        /// 错误号
        /// </summary>
		[JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
		[JsonProperty("msg")]
        public string Msg { get; set; }
    }

    public abstract class BaseResult<T> : BaseResult
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("data")]
        public virtual T Data { get; set; }
    }
}

