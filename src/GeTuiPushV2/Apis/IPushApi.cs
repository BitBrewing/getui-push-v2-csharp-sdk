using GeTuiPushV2.Apis.Attributes;
using GeTuiPushV2.Apis.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApiClientCore.Attributes;

namespace GeTuiPushV2.Apis
{
    /// <summary>
    /// 推送API
    /// <para>https://docs.getui.com/getui/server/rest_v2/push/</para>
    /// </summary>
    [ApiAuthorize]
    [JsonNetReturn(EnsureSuccessStatusCode = false)]
    public interface IPushApi
    {
        /// <summary>
        /// 向单个用户推送消息，可根据cid指定用户
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("push/single/cid")]
        Task<PushSingleResult> PushSingleCidAsync([JsonNetContent] PushSingleCidInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 通过别名推送消息
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("push/single/alias")]
        Task<PushSingleResult> PushSingleAliasAsync([JsonNetContent]PushSingleAliasInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 批量发送单推消息，每个cid用户的推送内容都不同的情况下，使用此接口，可提升推送效率。
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("push/single/batch/cid")]
        Task<PushBatchResult> PushSingleBatchCidAsync([JsonNetContent] PushSingleBatchCidInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 批量发送单推消息，在给每个别名用户的推送内容都不同的情况下，可以使用此接口
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("push/single/batch/alias")]
        Task<PushBatchResult> PushSingleBatchAliasAsync([JsonNetContent] PushSingleBatchAliasInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 对列表中所有cid进行消息推送。调用此接口前需调用创建消息接口设置消息内容。
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("push/list/cid")]
        Task<PushBatchResult> PushListCidAsync([JsonNetContent] PushListCidInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 对列表中所有别名进行消息推送。调用此接口前需调用创建消息接口设置消息内容。
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("push/list/alias")]
        Task<PushBatchResult> PushListAliasAsync([JsonNetContent] PushListAliasInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 对指定应用的所有用户群发推送消息
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>注：此接口频次限制100次/天，每分钟不能超过5次(推送限制和接口根据条件筛选用户推送共享限制)</remarks>
        [HttpPost("push/all")]
        Task<PushAllResult> PushAllAsync([JsonNetContent]PushAllInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 根据标签过滤用户并推送。支持定时、定速功能。
        /// </summary>
        /// <returns></returns>
        /// <remarks>注：该功能需要申请相关套餐，请点击右侧“技术咨询”了解详情 。</remarks>
        [HttpPost("push/fast_custom_tag")]
        Task<PushFastCustomTagResult> PushFastCustomTagAsync([JsonNetContent] PushFastCustomTagInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 此接口用来创建消息体，并返回taskid，为批量推的前置步骤
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>注：此接口频次限制200万次/天，申请修改请点击右侧“技术咨询”了解详情。</remarks>
        [HttpPost("push/list/message")]
        Task<PushListMessageResult> PushListMessageAsync([JsonNetContent] PushListMessageInput input, CancellationToken cancellationToken = default);

        /// <summary>
        /// 对正处于推送状态，或者未接收的消息停止下发（只支持批量推和群推任务）
        /// </summary>
        /// <param name="taskId">任务id (格式RASL-MMdd_XXXXXX或RASA-MMdd_XXXXXX)</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpDelete("task/{taskId}")]
        Task<BaseResult> DeleteTaskAsync([Required] string taskId, CancellationToken cancellationToken = default);
    }
}
