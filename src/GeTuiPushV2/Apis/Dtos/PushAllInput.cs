using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushAllInput: PushSingleInputBase
    {
        [JsonProperty("audience")]
#pragma warning disable IDE0052 // 删除未读的私有成员
        private readonly PushAudienceAll _audience = new();
#pragma warning restore IDE0052 // 删除未读的私有成员

        /// <summary>
        /// 任务组名（只允许填写数字、字母、横杠、下划线）
        /// </summary>
        [JsonProperty("group_name")]
        [RegularExpression(@"^[0-9a-zA-Z_-]+$")]
        public string GroupName { get; set; }
    }
}
