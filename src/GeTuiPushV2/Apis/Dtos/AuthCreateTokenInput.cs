using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
	public class AuthCreateTokenInput
    {
        [Required]
        [JsonProperty("sign")]
		public string Sign { get; set; }

        [Required]
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [Required]
        [JsonProperty("appkey")]
        public string AppKey { get; set; }
    }
}

