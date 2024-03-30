using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(JsonNameStringEnumConverter))]
    public enum PushAudienceTagKeyEnums
    {
        /// <summary>
        /// 手机类型
        /// </summary>
        [JsonProperty("phone_type")]
        PhoneType,

        /// <summary>
        /// 省市
        /// </summary>
        [JsonProperty("region")]
        Region,

        /// <summary>
        /// 用户标签
        /// </summary>
        [JsonProperty("custom_tag")]
        CustomTag,

        /// <summary>
        /// 个推用户画像
        /// </summary>
        [JsonProperty("portrait")]
        Portrait,
    }
}
