using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GeTuiPushV2
{
    public class GeTuiPushException: Exception
    {
        public GeTuiPushException(int code, string message): base(message)
        {
            Code = code;
        }

        protected GeTuiPushException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Code = info.GetInt32(nameof(Code));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Code), Code);

            base.GetObjectData(info, context);
        }

        public int Code { get; }
    }
}
