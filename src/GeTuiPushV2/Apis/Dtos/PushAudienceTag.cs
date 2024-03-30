using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushAudienceTag
    {
        /// <summary>
        /// 推送条件，数量不大于100个
        /// </summary>
        [Required]
        [JsonProperty("tag")]
        [MinLength(1)]
        [MaxLength(100)]
        public IEnumerable<PushAudienceTagItem> Tag { get; set; }
    }
}
