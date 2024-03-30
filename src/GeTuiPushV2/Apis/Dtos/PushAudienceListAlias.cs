using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(PushAudienceListAliasConverter))]
    public class PushAudienceListAlias
    {
        /// <summary>
        /// 别名列表
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1000)]
        public IEnumerable<string> Alias { get; set; }
    }
}
