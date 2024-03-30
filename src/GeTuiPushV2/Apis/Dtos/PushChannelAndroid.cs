using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelAndroid
    {
        /// <summary>
        /// android厂商通道推送消息内容
        /// </summary>
        [JsonProperty("ups")]
        public PushChannelAndroidUps Ups { get; set; }
    }
}
