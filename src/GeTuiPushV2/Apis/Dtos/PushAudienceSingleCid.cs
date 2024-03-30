using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(PushAudienceSingleCidConverter))]
    public class PushAudienceSingleCid
    {
        /// <summary>
        /// 客户端ID
        /// </summary>
        [Required]
        public string Cid { get; set; }
    }
}
