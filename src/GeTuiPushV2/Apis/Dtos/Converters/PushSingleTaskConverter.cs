using GeTuiPushV2.Apis.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeTuiPushV2.Apis.Dtos.Converters
{
    internal class PushSingleTaskConverter : PushTaskConverterBase<PushTaskCid>
    {
        protected override PushTaskCid ReadObject(Dictionary<string, Dictionary<string, PushTaskStatusEnums>> tasks)
        {
            if (tasks == null || tasks.Count == 0)
                return null;

            var firstTask = tasks.First();
            if (firstTask.Value.Count == 0)
                return null;

            var firstCid = firstTask.Value.First();

            return new PushTaskCid
            {
                TaskId = firstTask.Key,
                Cid = firstCid.Key,
                Status = firstCid.Value,
            };
        }

        protected override Dictionary<string, Dictionary<string, PushTaskStatusEnums>> WriteObject(PushTaskCid value)
        {
            if (value == null)
                return null;

            return new Dictionary<string, Dictionary<string, PushTaskStatusEnums>>
            {
                [value.TaskId] = new Dictionary<string, PushTaskStatusEnums>
                {
                    [value.Cid] = value.Status,
                },
            };
        }
    }
}
