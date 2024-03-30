using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelAndroidUpsNotification
    {
        /// <summary>
        /// 通知栏标题（长度建议取最小集）
        /// <para>小米：title长度限制为50字</para>
        /// <para>魅族：title长度限制32字</para>
        /// <para>OPPO：title长度限制50字</para>
        /// <para>VIVO：title长度限制40英文字符（最大20个汉字（一个汉字等于两个英文字符））</para>
        /// </summary>
        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 通知栏内容(长度建议取最小集)
        /// <para>HW：content长度限制256字</para>
        /// <para>小米：content长度限制128字</para>
        /// <para>魅族：content长度限制100字</para>
        /// <para>OPPO：content长度限制200字</para>
        /// <para>VIVO：content长度限制100英文字符（最大50个汉字（一个汉字等于两个英文字符））</para>
        /// </summary>
        [Required]
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 必填项，点击通知后续动作，
        /// 目前支持以下后续动作，
        /// intent：打开应用内特定页面(厂商都支持)，
        /// url：打开网页地址(厂商都支持；华为/荣耀要求https协议，且游戏类应用不支持打开网页地址)，
        /// startapp：打开应用首页(厂商都支持)
        /// </summary>
        [Required]
        [JsonProperty("click_type")]
        public PushChannelAndroidUpsNotificationClickTypeEnums ClickType { get; set; }

        /// <summary>
        /// click_type为intent时必填
        /// 点击通知打开应用特定页面，长度 ≤ 4096;
        /// 示例：intent://com.getui.push/detail?#Intent;scheme=gtpushscheme;launchFlags=0x4000000;package=com.getui.demo;component=com.getui.demo/com.getui.demo.DemoActivity;S.payload=payloadStr;end 
        /// </summary>
        [JsonProperty("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// click_type为url时必填，点击通知打开链接，长度 ≤ 1024
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 覆盖任务时会使用到该字段，两条消息的notify_id相同，新的消息会覆盖老的消息，范围：0-2147483647
        /// </summary>
        [JsonProperty("notify_id")]
        public int? NotifyId { get; set; }
    }
}
