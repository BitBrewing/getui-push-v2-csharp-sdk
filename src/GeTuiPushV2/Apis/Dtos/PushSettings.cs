using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushSettings
    {
        /// <summary>
        /// 消息离线时间设置，单位毫秒，-1表示不设离线，-1 ～ 3 * 24 * 3600 * 1000(3天)之间
        /// </summary>
        [JsonProperty("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// 厂商通道策略
        /// </summary>
        [JsonProperty("strategy")]
        public PushSettingsStrategy Strategy { get; set; }
    }
}
