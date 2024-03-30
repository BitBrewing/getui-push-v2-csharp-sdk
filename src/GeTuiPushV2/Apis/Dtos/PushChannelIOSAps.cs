using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelIOSAps
    {
        /// <summary>
        /// 通知消息
        /// </summary>
        [JsonProperty("alert")]
        public PushChannelIOSApsAlert Alert { get; set; }

        /// <summary>
        ///   否	0	0表示普通通知消息(默认为0)；
        ///   1表示静默推送(无通知栏消息)，静默推送时不需要填写其他参数。
        ///   苹果建议1小时最多推送3条静默消息
        /// </summary>
        [JsonProperty("content-available")]
        public int? ContentAvailable { get; set; }

        /// <summary>
        /// 通知铃声文件名，如果铃声文件未找到，响铃为系统默认铃声。
        /// 无声设置为“com.gexin.ios.silence”或不填
        /// </summary>
        [JsonProperty("sound")]
        public string Sound { get; set; }

        /// <summary>
        /// 在客户端通知栏触发特定的action和button显示
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// ios的远程通知通过该属性对通知进行分组，仅支持iOS 12.0以上版本
        /// </summary>
        [JsonProperty("thread-id")]
        public string ThreadId { get; set; }
    }
}
