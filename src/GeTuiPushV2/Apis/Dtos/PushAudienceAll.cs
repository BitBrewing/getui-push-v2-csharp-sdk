using GeTuiPushV2.Apis.Dtos.Converters;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    [JsonConverter(typeof(PushAudienceAllConverter))]
    internal class PushAudienceAll
    {
    }
}
