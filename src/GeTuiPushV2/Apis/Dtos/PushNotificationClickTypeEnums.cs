using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(JsonNameStringEnumConverter))]
    public enum PushNotificationClickTypeEnums
    {
        /// <summary>
        /// 打开应用内特定页面
        /// </summary>
        [JsonProperty("intent")]
        Intent,

        /// <summary>
        /// 打开网页地址
        /// </summary>
        [JsonProperty("url")]
        Url,

        /// <summary>
        /// 自定义消息内容启动应用
        /// </summary>
        [JsonProperty("payload")]
        Payload,

        /// <summary>
        /// 自定义消息内容不启动应用
        /// </summary>
        [JsonProperty("payload_custom")]
        PayloadCustom,

        /// <summary>
        /// 打开应用首页
        /// </summary>
        [JsonProperty("startapp")]
        StartApp,

        /// <summary>
        /// 纯通知，无后续动作
        /// </summary>
        [JsonProperty("none")]
        None,
    }
}
