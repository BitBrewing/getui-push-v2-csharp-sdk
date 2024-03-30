using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public abstract class PushSingleInputBase
    {
        /// <summary>
        /// 请求唯一标识号，10-32位之间；如果request_id重复，会导致消息丢失
        /// </summary>
        [Required]
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 推送条件设置
        /// </summary>
        [JsonProperty("settings")]
        public PushSettings Settings { get; set; }

        /// <summary>
        /// 个推推送消息参数
        /// </summary>
        [Required]
        [JsonProperty("push_message")]
        public PushMessage PushMessage { get; set; }

        /// <summary>
        /// 厂商推送消息参数，包含ios消息参数，android厂商消息参数
        /// </summary>
        [JsonProperty("push_channel")]
        public PushChannel PushChannel { get; set; }
    }

    public abstract class PushSingleInputBase<TAudience>: PushSingleInputBase where TAudience : class
    {
        /// <summary>
        /// 推送目标用户
        /// </summary>
        [Required]
        [JsonProperty("audience")]
        public TAudience Audience { get; set; }
    }
}
