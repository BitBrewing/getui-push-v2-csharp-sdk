using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelIOS
    {
        /// <summary>
        /// 默认值notify，voip：voip语音推送，notify：apns通知消息
        /// </summary>
        [JsonProperty("type")]
        public PushChannelIOSTypeEnums Type { get; set; }

        /// <summary>
        /// 推送通知消息内容
        /// </summary>
        [JsonProperty("aps")]
        public PushChannelIOSAps Aps { get; set; }

        /// <summary>
        ///  用于计算icon上显示的数字，还可以实现显示数字的自动增减，如“+1”、 “-1”、 “1” 等，计算结果将覆盖badge
        /// </summary>
        [JsonProperty("auto_badge")]
        public string AutoBadge { get; set; }

        /// <summary>
        /// 增加自定义的数据
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 多媒体设置，最多可设置3个子项
        /// </summary>
        [JsonProperty("multimedia")]
        public IEnumerable<PushChannelIOSApsMultimedia> Multimedia { get; set; }

        /// <summary>
        /// 使用相同的apns-collapse-id可以覆盖之前的消息
        /// </summary>
        [JsonProperty("apns-collapse-id")]
        public string ApnsCollapseId { get; set; }
    }
}
