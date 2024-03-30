using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class JsonNameStringEnumConverter : StringEnumConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var type = value.GetType();
            if (!type.IsEnum)
                throw new InvalidOperationException("Only enum type is supported");

            // 获取枚举字段
            FieldInfo fieldInfo = type.GetField(value.ToString());
            // 尝试获取JsonProperty属性
            if (fieldInfo.GetCustomAttributes(typeof(JsonPropertyAttribute), false)
                .FirstOrDefault() is JsonPropertyAttribute attr)
            {
                // 如果存在JsonProperty属性，使用其指定的名称
                writer.WriteValue(attr.PropertyName);
            }
            else
            {
                // 如果不存在JsonProperty属性，使用枚举的字符串表示
                base.WriteJson(writer, value, serializer);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumType = Nullable.GetUnderlyingType(objectType) ?? objectType;
            if (!enumType.IsEnum)
                throw new InvalidOperationException("Only enum type is supported");

            string enumText = reader.Value?.ToString();

            foreach (var field in enumType.GetFields())
            {
                var attribute = field.GetCustomAttribute<JsonPropertyAttribute>();
                if (attribute != null && attribute.PropertyName == enumText)
                {
                    return Enum.Parse(enumType, field.Name);
                }
            }

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}
