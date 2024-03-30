using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(JsonNameStringEnumConverter))]
    public enum PushChannelIOSTypeEnums
    {
        /// <summary>
        /// apns通知消息
        /// </summary>
        [JsonProperty("notify")]
        Notify,

        /// <summary>
        /// 语音推送
        /// </summary>
        [JsonProperty("voip")]
        Voip,
    }
}
