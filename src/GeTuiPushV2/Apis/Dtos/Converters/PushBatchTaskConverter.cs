using System;
using System.Collections.Generic;
using System.Linq;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushBatchTaskConverter : PushTaskConverterBase<IReadOnlyList<PushTaskCid>>
    {
        protected override IReadOnlyList<PushTaskCid> ReadObject(Dictionary<string, Dictionary<string, PushTaskStatusEnums>> tasks)
        {
            if (tasks == null)
                return null;

            return tasks.SelectMany(t => t.Value.Select(c => new PushTaskCid
            {
                TaskId = t.Key,
                Cid = c.Key,
                Status = c.Value,
            })).ToArray();
        }

        protected override Dictionary<string, Dictionary<string, PushTaskStatusEnums>> WriteObject(IReadOnlyList<PushTaskCid> value)
        {
            if (value == null)
                return null;

            return value.ToLookup(t => t.TaskId).ToDictionary(t => t.Key, t => t.ToDictionary(c => c.Cid, c => c.Status));
        }
    }
}

