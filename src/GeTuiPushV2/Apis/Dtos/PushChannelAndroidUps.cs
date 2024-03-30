using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelAndroidUps
    {
        /// <summary>
        /// 通知消息内容，与transmission、revoke三选一，都填写时报错。若希望客户端离线时，直接在系统通知栏中展示通知栏消息，推荐使用此参数。
        /// </summary>
        [JsonProperty("notification")]
        public PushChannelAndroidUpsNotification Notification { get; set; }

        /// <summary>
        /// 透传消息内容，与notification、revoke 三选一，都填写时报错，长度 ≤ 3072
        /// </summary>
        [JsonProperty("transmission")]
        public string Transmission { get; set; }

        /// <summary>
        /// 撤回消息时使用(仅撤回厂商通道消息，支持的厂商有小米、VIVO)，与notification、transmission三选一，都填写时报错(消息撤回请勿填写策略参数)
        /// </summary>
        [JsonProperty("revoke")]
        public PushChannelAndroidUpsRevoke Revoke { get; set; }

        /// <summary>
        /// 第三方厂商扩展内容
        /// </summary>
        [JsonProperty("options")]
        public PushChannelAndroidUpsOptions Options { get; set; }
    }
}
