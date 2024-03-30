using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushAudienceTagItem
    {
        /// <summary>
        /// 查询条件(phone_type 手机类型; region 省市; custom_tag 用户标签; portrait 个推用户画像。
        /// </summary>
        [Required]
        [JsonProperty("key")]
        public PushAudienceTagKeyEnums? Key { get; set; }

        /// <summary>
        /// 查询条件值列表，其中
        /// 手机型号使用如下参数android,ios和miniProgram；
        /// 省市使用编号，https://docs.getui.com/files/region_code.data；
        /// 个推用户画像使用编码，https://docs.getui.com/files/portrait.data
        /// </summary>
        [Required]
        [MinLength(1)]
        [JsonProperty("values")]
        public IEnumerable<string> Values { get; set; }

        /// <summary>
        /// or(或),and(与),not(非)，values间的交并补操作
        /// <para>不同key之间是交集，同一个key之间是根据opt_type操作</para>
        /// <para><![CDATA[eg. 需要发送给城市在A,B,C里面，没有设置tagtest标签，手机型号为android的用户，用条件交并补功能可以实现，city(A|B|C) && !tag(tagtest) && phonetype(android)]]></para>
        /// </summary>
        [JsonProperty("opt_type")]
        public PushAudienceOptTypeEnums? OptType { get; set; }
    }
}
