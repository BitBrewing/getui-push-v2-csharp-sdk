using GeTuiPushV2.Apis.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushAudienceSingleAliasConverter : PushAudienceConverterBase<PushAudienceSingleAlias>
    {
        protected override PushAudienceSingleAlias ReadObject(PushAudience audience)
        {
            return new PushAudienceSingleAlias
            {
                Alias = audience.Alias[0],
            };
        }

        protected override PushAudience WriteObject(PushAudienceSingleAlias value)
        {
            return new PushAudience
            {
                Alias = [value.Alias],
            };
        }
    }
}
