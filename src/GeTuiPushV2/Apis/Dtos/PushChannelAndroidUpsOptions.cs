using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelAndroidUpsOptions
    {
        /// <summary>
        /// 扩展内容对应厂商通道设置如：ALL,HW,HO,XM(小米国内),XMG(小米海外),VV,OP,OPG(OPPO海外),MZ,UPS(UPS的参数会影响UPS下面的所有机型，比如ST,SN等等)
        /// </summary>
        [JsonProperty("constraint")]
        public string Constraint { get; set; }

        /// <summary>
        /// 厂商内容扩展字段
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// value的设置根据key值决定
        /// </summary>
        [JsonProperty("value")]
        public dynamic Value { get; set; }
    }
}
