using System;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    public class PushDurationConverter : JsonConverter<PushDuration>
    {
        public override PushDuration ReadJson(JsonReader reader, Type objectType, PushDuration existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string value = reader.ReadAsString();
            
            // 检查输入是否为空
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            // 分割字符串以获取开始和结束时间的Unix时间戳
            var parts = value.Split('-');
            if (parts.Length != 2)
            {
                throw new JsonSerializationException("Invalid PushDuration format.");
            }

            // 尝试解析开始和结束时间的Unix时间戳
            if (long.TryParse(parts[0], out long beginTimeUnix) && long.TryParse(parts[1], out long endTimeUnix))
            {
                // Unix时间戳转DateTimeOffset
                var beginTime = DateTimeOffset.FromUnixTimeMilliseconds(beginTimeUnix);
                var endTime = DateTimeOffset.FromUnixTimeMilliseconds(endTimeUnix);

                // 创建并返回PushDuration实例
                return new PushDuration { BeginTime = beginTime, EndTime = endTime };
            }
            else
            {
                throw new JsonSerializationException("Invalid Unix timestamps in PushDuration.");
            }
        }

        public override void WriteJson(JsonWriter writer, PushDuration value, JsonSerializer serializer)
        {
            if (value.BeginTime == null || value.EndTime == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue($"{value.BeginTime.Value.ToUnixTimeMilliseconds()}-{value.EndTime.Value.ToUnixTimeMilliseconds()}");
            }
        }
    }
}

