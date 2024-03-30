using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushAudience
    {
        [JsonProperty("alias")]
        public string[] Alias { get; set; }

        [JsonProperty("cid")]
        public string[] Cid { get; set; }

        [JsonProperty("smart_crowd_task_id")]
        public string SmartCrowdTaskId { get; set; }

        [JsonProperty("crowd_id")]
        public string CrowdId { get; set; }
    }
}
