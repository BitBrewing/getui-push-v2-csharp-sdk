using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushSingleResult: BaseResult<PushTaskCid>
    {
        [JsonConverter(typeof(PushSingleTaskConverter))]
        public override PushTaskCid Data { get => base.Data; set => base.Data = value; }
    }
}
