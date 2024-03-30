using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class UserAliasInput
    {
        /// <summary>
        /// 数据列表，数组长度不大于1000
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1000)]
        [JsonProperty("data_list")]
        public IEnumerable<UserAliasData> DataList { get; set; }
    }
}