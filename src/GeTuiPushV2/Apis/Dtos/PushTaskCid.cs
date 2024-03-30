using System.Text;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushTaskCid
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// App的用户唯一标识
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 推送结果
        /// </summary>
        public PushTaskStatusEnums Status { get; set; }
    }
}
