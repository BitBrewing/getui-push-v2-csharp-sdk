using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannel
    {
        /// <summary>
        /// ios通道推送消息内容
        /// </summary>
        [JsonProperty("ios")]
        public PushChannelIOS iOS { get; set; }

        /// <summary>
        /// android通道推送消息内容
        /// </summary>
        [JsonProperty("android")]
        public PushChannelAndroid Android { get; set; }

        /// <summary>
        /// miniProgram通道推送消息内容(只支持透传消息)
        /// </summary>
        [JsonProperty("mp")]
        public PushChannelMP MP { get; set; }
    }
}
