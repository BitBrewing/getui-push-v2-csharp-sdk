using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushListAliasInput: PushListInputBase<PushAudienceListAlias>
    {
        /// <summary>
        /// 是否返回别名详情,返回别名详情的前提：is_async=false
        /// </summary>
        [JsonProperty("need_alias_detail")]
        public bool? NeedAliasDetail { get; set; }
    }
}
