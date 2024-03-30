using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelAndroidUpsRevoke
    {
        /// <summary>
        /// 必填项，需要撤回的taskId
        /// </summary>
        [Required]
        [JsonProperty("old_task_id")]
        public string OldTaskId { get; set; }
    }
}
