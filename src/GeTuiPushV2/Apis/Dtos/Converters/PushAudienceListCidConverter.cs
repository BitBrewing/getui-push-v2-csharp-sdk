using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushAudienceListCidConverter : PushAudienceConverterBase<PushAudienceListCid>
    {
        protected override PushAudienceListCid ReadObject(PushAudience audience)
        {
            return new PushAudienceListCid
            {
                Cid = audience.Cid,
                CrowdId = audience.CrowdId,
                SmartCrowdTaskId = audience.SmartCrowdTaskId,
            };
        }

        protected override PushAudience WriteObject(PushAudienceListCid value)
        {
            return new PushAudience
            {
                Cid = [.. value.Cid],
                CrowdId = value.CrowdId,
                SmartCrowdTaskId = value.SmartCrowdTaskId,
            };
        }
    }
}
