using System;
using System.Collections.Generic;
using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
	public class PushBatchResult: BaseResult<IReadOnlyList<PushTaskCid>>
    {
        [JsonConverter(typeof(PushBatchTaskConverter))]
        public override IReadOnlyList<PushTaskCid> Data { get => base.Data; set => base.Data = value; }
    }
}

