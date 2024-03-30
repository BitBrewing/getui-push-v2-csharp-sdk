using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushAudienceListAliasConverter : PushAudienceConverterBase<PushAudienceListAlias>
    {
        protected override PushAudienceListAlias ReadObject(PushAudience audience)
        {
            return new PushAudienceListAlias
            {
                Alias = audience.Alias,
            };
        }

        protected override PushAudience WriteObject(PushAudienceListAlias value)
        {
            return new PushAudience
            {
                Alias = [.. value.Alias],
            };
        }
    }
}
