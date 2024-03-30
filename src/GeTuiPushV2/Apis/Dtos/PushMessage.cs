using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushMessage
    {
        /// <summary>
        /// 手机端通知展示时间段，格式为毫秒时间戳段，两个时间的时间差必须大于10分钟，例如："1590547347000-1590633747000"
        /// </summary>
        public PushDuration Duration { get; set; }

        /// <summary>
        /// 通知消息内容，安卓系统和鸿蒙系统支持，iOS系统不展示个推通知消息，与transmission、revoke三选一，都填写时报错
        /// </summary>
        [JsonProperty("notification")]
        public PushNotification Notification { get; set; }

        /// <summary>
        /// 纯透传消息内容，安卓和iOS均支持，与notification、revoke 三选一，都填写时报错，长度 ≤ 3072字
        /// </summary>
        [JsonProperty("transmission")]
        public string Transmission { get; set; }

        /// <summary>
        /// 撤回消息时使用(仅撤回个推通道消息)，与notification、transmission三选一，都填写时报错(消息撤回请勿填写策略参数)
        /// </summary>
        [JsonProperty("revoke")]
        public PushRevoke Revoke { get; set; }
    }
}
