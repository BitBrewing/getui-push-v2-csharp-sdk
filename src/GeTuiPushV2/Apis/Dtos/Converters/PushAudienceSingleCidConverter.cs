using GeTuiPushV2.Apis.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushAudienceSingleCidConverter : PushAudienceConverterBase<PushAudienceSingleCid>
    {
        protected override PushAudienceSingleCid ReadObject(PushAudience audience)
        {
            return new PushAudienceSingleCid
            {
                Cid = audience.Cid[0],
            };
        }

        protected override PushAudience WriteObject(PushAudienceSingleCid value)
        {
            return new PushAudience
            {
                Cid = new string[] { value.Cid },
            };
        }
    }
}
