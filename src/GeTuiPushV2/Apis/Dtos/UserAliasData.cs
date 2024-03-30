using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class UserAliasData
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        [Required]
        [JsonProperty("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 别名，有效的别名组成：
        /// 字母（区分大小写）、数字、下划线、汉字;
        /// 长度<![CDATA[<]]>40字;
        /// 一个别名最多允许绑定10个cid。
        /// </summary>
        [Required]
        [StringLength(40)]
        [RegularExpression("^[a-zA-Z0-9_\u4e00-\u9fa5]+$")]
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }
}