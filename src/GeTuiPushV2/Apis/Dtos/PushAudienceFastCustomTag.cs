using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushAudienceFastCustomTag
    {
        /// <summary>
        /// 使用用户标签筛选目标用户
        /// </summary>
        [Required]
        [JsonProperty("fast_custom_tag")]
        public string FastCustomTag { get; set; }
    }
}
