using GeTuiPushV2.Apis.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal abstract class PushTaskConverterBase<T> : JsonConverter<T>
    {
        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var tasks = serializer.Deserialize<Dictionary<string, Dictionary<string, PushTaskStatusEnums>>>(reader);
            return ReadObject(tasks);
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, WriteObject(value));
        }

        protected abstract T ReadObject(Dictionary<string, Dictionary<string, PushTaskStatusEnums>> tasks);

        protected abstract Dictionary<string, Dictionary<string, PushTaskStatusEnums>> WriteObject(T value);
    }
}
