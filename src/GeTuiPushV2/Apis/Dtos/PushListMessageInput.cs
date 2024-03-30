using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushListMessageInput
    {
        /// <summary>
        /// 任务组名（只允许填写数字、字母、横杠、下划线）
        /// </summary>
        [JsonProperty("group_name")]
        [RegularExpression(@"^[0-9a-zA-Z_-]+$")]
        public string GroupName { get; set; }

        /// <summary>
        /// 推送条件设置
        /// </summary>
        [JsonProperty("settings")]
        public PushSettings Settings { get; set; }

        /// <summary>
        /// 个推推送消息参数
        /// </summary>
        [Required]
        [JsonProperty("push_message")]
        public PushMessage PushMessage { get; set; }

        /// <summary>
        /// 厂商推送消息参数，包含ios消息参数，android厂商消息参数
        /// </summary>
        [JsonProperty("push_channel")]
        public PushChannel PushChannel { get; set; }
    }
}
