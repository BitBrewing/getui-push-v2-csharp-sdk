using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
	public abstract class PushSingleBatchInputBase<T> where T: PushSingleInputBase
    {
        /// <summary>
        /// 是否异步推送，true是异步，false同步。异步推送不会返回data详情
        /// </summary>
        [JsonProperty("is_async")]
		public bool? IsAsync { get; set; }

        /// <summary>
        /// 消息内容，数组长度不大于200
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        [JsonProperty("msg_list")]
        public IEnumerable<T> MsgList { get; set; }
    }
}

