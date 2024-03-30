using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(JsonNameStringEnumConverter))]
    public enum PushChannelAndroidUpsNotificationClickTypeEnums
    {
        /// <summary>
        /// 打开应用内特定页面(厂商都支持)
        /// </summary>
        [JsonProperty("intent")]
        Intent,

        /// <summary>
        /// 打开网页地址(厂商都支持；华为/荣耀要求https协议，且游戏类应用不支持打开网页地址)
        /// </summary>
        [JsonProperty("url")]
        Url,

        /// <summary>
        /// 打开应用首页(厂商都支持)
        /// </summary>
        [JsonProperty("startapp")]
        StartApp,
    }
}
