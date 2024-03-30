using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    /// <summary>
    /// 说明：cid、smart_crowd_task_id、crowd_id必须3选1
    /// </summary>
    [JsonConverter(typeof(PushAudienceListCidConverter))]
    public class PushAudienceListCid
    {
        /// <summary>
        /// cid列表
        /// </summary>
        [MinLength(1)]
        [MaxLength(1000)]
        public IEnumerable<string> Cid { get; set; }

        /// <summary>
        /// 文案圈人任务ID，必须是can_push为true的ID才可以进行推送
        /// </summary>
        public string SmartCrowdTaskId { get; set; }

        /// <summary>
        /// 用户群ID，仅“用户群管理”模块中的“用户群”在去触达状态生效时可使用
        /// </summary>
        public string CrowdId { get; set; }
    }
}
