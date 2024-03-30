using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal abstract class PushAudienceConverterBase<T> : JsonConverter<T>
    {
        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var audience = serializer.Deserialize<PushAudience>(reader);
            return ReadObject(audience);
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, WriteObject(value));
        }

        protected abstract T ReadObject(PushAudience audience);

        protected abstract PushAudience WriteObject(T value);
    }
}
