using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        /// <summary>
        /// 定速推送，例如100，个推控制下发速度在100条/秒左右，0表示不限速
        /// </summary>
        /// <remarks>该参数仅 /push/all、/push/tag、/push/fast_custom_tag 支持</remarks>
        [JsonProperty("speed")]
        public int? Speed { get; set; }

        /// <summary>
        /// 定时推送时间，必须是7天内的时间，格式：毫秒时间戳，此功能需要开通VIP，如需开通请点击右侧“技术咨询”了解详情
        /// </summary>
        /// <remarks>该参数仅 /push/all、/push/tag 支持</remarks>
        [JsonProperty("schedule_time")]
        public int? ScheduleTime { get; set; }
    }
}
