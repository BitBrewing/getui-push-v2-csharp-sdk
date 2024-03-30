using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushSettingsStrategy
    {
        /// <summary>
        /// 默认所有通道的策略选择1-4
        /// <para>1: 表示该消息在用户在线时推送个推通道，用户离线时推送厂商通道;</para>
        /// <para>2: 表示该消息只通过厂商通道策略下发，不考虑用户是否在线;</para>
        /// <para>3: 表示该消息只通过个推通道下发，不考虑用户是否在线；</para>
        /// <para>4: 表示该消息优先从厂商通道下发，若消息内容在厂商通道代发失败后会从个推通道下发。</para>
        /// </summary>
        [JsonProperty("default")]
        public int? Default { get; set; }

        /// <summary>
        /// ios 通道策略1-4，表示含义同上，要推送ios通道，需要在个推开发者中心上传ios证书，建议填写2或4，否则可能会有消息不展示的问题
        /// </summary>
        [JsonProperty("ios")]
        public int? iOS { get; set; }

        /// <summary>
        /// 华为 通道策略1-4，表示含义同上
        /// </summary>
        [JsonProperty("hw")]
        public int? HW { get; set; }

        /// <summary>
        /// 荣耀 通道策略1-4，表示含义同上
        /// </summary>
        [JsonProperty("ho")]
        public int? HO { get; set; }

        /// <summary>
        /// 小米 通道策略1-4和6，表示含义同上
        /// <para>6: 表示该消息选用厂商智能配额策略，用户在线时推送个推通道，用户离线时常活跃用户推送个推通道，低活跃用户推送厂商通道。</para>
        /// </summary>
        [JsonProperty("xm")]
        public int? XM { get; set; }

        /// <summary>
        /// 小米海外 通道策略1-4，表示含义同上
        /// </summary>
        [JsonProperty("xmg")]
        public int? XMG { get; set; }

        /// <summary>
        /// vivo 通道策略1-4和6，表示含义同上
        /// </summary>
        [JsonProperty("vv")]
        public int? VV { get; set; }

        /// <summary>
        /// oppo 通道策略1-4和6，表示含义同上
        /// </summary>
        [JsonProperty("op")]
        public int? OP { get; set; }

        /// <summary>
        /// oppo海外 通道策略1-4，表示含义同上
        /// </summary>
        [JsonProperty("opg")]
        public int? OPG { get; set; }

        /// <summary>
        /// 魅族 通道策略1-4和6，表示含义同上
        /// </summary>
        [JsonProperty("mz")]
        public int? MZ { get; set; }

        /// <summary>
        /// 鸿蒙华为 通道策略1-4，表示含义同上
        /// </summary>
        [JsonProperty("hoshw")]
        public int? HOSHW { get; set; }

        /// <summary>
        /// 锤子/坚果 通道策略1-4，表示含义同上，需要开通ups厂商使用该通道推送消息
        /// </summary>
        [JsonProperty("st")]
        public int? ST { get; set; }

        /// <summary>
        /// 微信 通道策略1-4，表示含义同上，需要授权微信小程序使用该通道推送消息
        /// </summary>
        [JsonProperty("wx")]
        public int? WX { get; set; }
    }
}
