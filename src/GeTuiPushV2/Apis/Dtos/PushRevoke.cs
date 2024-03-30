using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushRevoke
    {
        /// <summary>
        /// 必填项，需要撤回的taskId
        /// </summary>
        [Required]
        [JsonProperty("old_task_id")]
        public string OldTaskId { get; set; }

        /// <summary>
        /// 在没有找到对应的taskId，是否把对应appId下所有的通知都撤回
        /// </summary>
        [JsonProperty("force")]
        public bool? Force { get; set; }
    }
}
