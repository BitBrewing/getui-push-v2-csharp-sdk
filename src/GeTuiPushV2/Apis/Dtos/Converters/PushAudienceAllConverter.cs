using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushAudienceAllConverter : JsonConverter<PushAudienceAll>
    {
        public override PushAudienceAll ReadJson(JsonReader reader, Type objectType, PushAudienceAll existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new PushAudienceAll();
        }

        public override void WriteJson(JsonWriter writer, PushAudienceAll value, JsonSerializer serializer)
        {
            writer.WriteValue("all");
        }
    }
}
