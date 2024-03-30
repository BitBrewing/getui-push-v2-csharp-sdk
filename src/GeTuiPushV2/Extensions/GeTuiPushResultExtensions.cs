using GeTuiPushV2.Apis.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeTuiPushV2.Apis
{
    public static class GeTuiPushResultExtensions
    {
        /// <summary>
        /// 确保输出结果正确，如果输出结果表示错误，则抛出异常。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <returns></returns>
        /// <exception cref="GeTuiPushException"></exception>
        public static T EnsureThrowError<T>(this T output) where T : BaseResult
        {
            // 如果输出结果的Code属性不为0，表示存在错误
            if (output.Code != 0)
            {
                // 抛出异常，异常信息为输出结果的Msg属性
                throw new GeTuiPushException(output.Code, output.Msg);
            }

            // 如果输出结果Code为0，表示操作成功，直接返回原输出对象
            return output;
        }

        /// <summary>
        /// 确保输出结果正确，如果输出结果表示错误，则抛出异常。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="outputTask"></param>
        /// <returns></returns>
        public static async Task<T> EnsureThrowErrorAsync<T>(this Task<T> outputTask) where T : BaseResult
        {
            return (await outputTask.ConfigureAwait(false)).EnsureThrowError();
        }
    }
}
