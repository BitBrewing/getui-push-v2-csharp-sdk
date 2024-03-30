using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(JsonNameStringEnumConverter))]
    public enum PushTaskStatusEnums
    {
        /// <summary>
        /// 离线下发(包含厂商通道下发)
        /// </summary>
        [JsonProperty("successed_offline")]
        SuccessedOffline,

        /// <summary>
        /// 在线下发
        /// </summary>
        [JsonProperty("successed_online")]
        SuccessedOnline,

        /// <summary>
        /// 最近90天内不活跃用户不下发
        /// </summary>
        [JsonProperty("successed_ignore")]
        SuccessedIgnore,
    }
}
