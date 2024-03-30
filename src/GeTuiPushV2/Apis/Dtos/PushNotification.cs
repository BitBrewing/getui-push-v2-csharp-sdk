using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushNotification
    {
        /// <summary>
        /// 必填项，通知消息标题，长度 ≤ 50
        /// </summary>
        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 必填项，通知消息内容，长度 ≤ 256
        /// </summary>
        [Required]
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 长文本消息内容，通知消息+长文本样式，与big_image二选一，两个都填写时报错，长度 ≤ 512
        /// </summary>
        [JsonProperty("big_text")]
        public string BigText { get; set; }

        /// <summary>
        /// 大图的URL地址，通知消息+大图样式， 与big_text二选一，两个都填写时报错，长度 ≤ 1024
        /// </summary>
        [JsonProperty("big_image")]
        public string BigImage { get; set; }

        /// <summary>
        /// 通知的图标名称，包含后缀名（需要在客户端开发时嵌入），如“push.png”，长度 ≤ 64
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 通知图标URL地址，长度 ≤ 256
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 默认值Default 通知渠道id，长度 ≤ 64
        /// </summary>
        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 默认值Default 通知渠道名称，长度 ≤ 64
        /// </summary>
        [JsonProperty("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 设置通知渠道重要性（可以控制响铃，震动，浮动，闪灯等等）
        /// android8.0以下
        /// 0，1，2:无声音，无振动，不浮动
        /// 3:有声音，无振动，不浮动
        /// 4:有声音，有振动，有浮动
        /// android8.0以上
        /// 0：无声音，无振动，不显示；
        /// 1：无声音，无振动，锁屏不显示，通知栏中被折叠显示，导航栏无logo;
        /// 2：无声音，无振动，锁屏和通知栏中都显示，通知不唤醒屏幕;
        /// 3：有声音，无振动，锁屏和通知栏中都显示，通知唤醒屏幕;
        /// 4：有声音，有振动，亮屏下通知悬浮展示，锁屏通知以默认形式展示且唤醒屏幕;
        /// 默认值3
        /// </summary>
        [JsonProperty("channel_level")]
        public int? ChannelLevel { get; set; }

        /// <summary>
        /// 必填项，点击通知后续动作，
        /// 目前支持以下后续动作，
        /// intent：打开应用内特定页面，
        /// url：打开网页地址，
        /// payload：自定义消息内容启动应用，
        /// payload_custom：自定义消息内容不启动应用，
        /// startapp：打开应用首页，
        /// none：纯通知，无后续动作
        /// </summary>
        [Required]
        [JsonProperty("click_type")]
        public PushNotificationClickTypeEnums ClickType { get; set; }

        /// <summary>
        /// click_type为intent时必填
        /// 点击通知打开应用特定页面，长度 ≤ 4096;
        /// 示例：intent://com.getui.push/detail?#Intent;scheme=gtpushscheme;launchFlags=0x4000000;package=com.getui.demo;component=com.getui.demo/com.getui.demo.DemoActivity;S.payload=payloadStr;end 
        /// </summary>
        [JsonProperty("intent")]
        public string Intent { get; set; }

        /// <summary>
        /// 针对鸿蒙系统设置点击通知打开应用特定页面，长度小于1000字节，通知带want传递参数（json格式）
        /// </summary>
        [JsonProperty("want")]
        public string Want { get; set; }

        /// <summary>
        /// click_type为url时必填，点击通知打开链接，长度 ≤ 1024
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// click_type为payload/payload_custom时必填，点击通知时，附加自定义透传消息，长度 ≤ 3072
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 覆盖任务时会使用到该字段，两条消息的notify_id相同，新的消息会覆盖老的消息，范围：0-2147483647
        /// </summary>
        [JsonProperty("notify_id")]
        public int? NotifyId { get; set; }

        /// <summary>
        /// 自定义铃声，请填写文件名，不包含后缀名(需要在客户端开发时嵌入)，个推通道下发有效        
        /// 客户端SDK最低要求 2.14.0.0
        /// </summary>
        [JsonProperty("ring_name")]
        public string RingName { get; set; }

        /// <summary>
        /// 角标, 必须大于0, 个推通道下发有效
        /// 此属性目前仅针对华为 EMUI 4.1 及以上设备有效
        /// 角标数字数据会和之前角标数字进行叠加；
        /// 举例：角标数字配置1，应用之前角标数为2，发送此角标消息后，应用角标数显示为3。
        /// 客户端SDK最低要求 2.14.0.0
        /// </summary>
        [JsonProperty("badge_add_num")]
        public int? BadgeAddNum { get; set; }

        /// <summary>
        /// 消息折叠分组，设置成相同thread_id的消息会被折叠（仅支持个推渠道下发的安卓消息）。目前与iOS的thread_id设置无关，安卓和iOS需要分别设置。
        /// </summary>
        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        /// <summary>
        /// 个推通道华为消息分类，可选值：CATEGORY_PROMO, CATEGORY_RECOMMENDATION, CATEGORY_SOCIAL, CATEGORY_CALL, CATEGORY_EMAIL, CATEGORY_MESSAGE, CATEGORY_NAVIGATION, CATEGORY_REMINDER, CATEGORY_SERVICE, CATEGORY_ALARM, CATEGORY_STOPWATCH, CATEGORY_PROGRESS, CATEGORY_LOCATION_SHARING。
        /// <para>参考：华为消息分类标准 -本地通知适配</para>
        /// <para>客户端SDK最低要求 3.3.1.0</para>
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
    }
}
