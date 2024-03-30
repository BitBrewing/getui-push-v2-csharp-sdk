using System;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
	public class PushTask
	{
        /// <summary>
        /// 任务编号
        /// </summary>
        [JsonProperty("taskid")]
        public string TaskId { get; set; }
    }
}

