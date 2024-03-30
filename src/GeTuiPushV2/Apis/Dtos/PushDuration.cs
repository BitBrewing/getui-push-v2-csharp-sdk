using System;
using System.ComponentModel.DataAnnotations;
using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
	[JsonConverter(typeof(PushDurationConverter))]
	public class PushDuration
	{
		[Required]
		public DateTimeOffset? BeginTime { get; set; }

        [Required]
        public DateTimeOffset? EndTime { get; set; }
    }
}

