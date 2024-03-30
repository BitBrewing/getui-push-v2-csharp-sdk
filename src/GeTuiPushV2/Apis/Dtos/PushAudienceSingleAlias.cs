using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(PushAudienceSingleAliasConverter))]
    public class PushAudienceSingleAlias
    {
        /// <summary>
        /// 别名
        /// </summary>
        [Required]
        public string Alias { get; set; }
    }
}
