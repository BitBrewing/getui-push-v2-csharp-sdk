using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(JsonNameStringEnumConverter))]
    public enum PushAudienceOptTypeEnums
    {
        /// <summary>
        /// 或
        /// </summary>
        [JsonProperty("or")]
        Or,

        /// <summary>
        /// 与
        /// </summary>
        [JsonProperty("and")]
        And,

        /// <summary>
        /// 非
        /// </summary>
        [JsonProperty("not")]
        Not,
    }
}
