using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public abstract class PushListInputBase<TAudience> where TAudience: class
    {
        /// <summary>
        /// 是否异步推送，true是异步，false同步。异步推送不会返回data详情
        /// </summary>
        [JsonProperty("is_async")]
        public bool? IsAsync { get; set; }

        /// <summary>
        /// 使用创建消息接口返回的taskId，可以多次使用
        /// </summary>
        [Required]
        [JsonProperty("taskid")]
        public string TaskId { get; set; }

        /// <summary>
        /// 推送目标用户
        /// </summary>
        [Required]
        [JsonProperty("audience")]
        public TAudience Audience { get; set; }
    }
}
