using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GeTuiPushV2.Apis.Dtos
{
    public class PushChannelIOSApsAlert
    {
        /// <summary>
        /// 通知消息标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 通知消息内容
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// （用于多语言支持）指定执行按钮所使用的Localizable.strings
        /// </summary>
        [JsonProperty("action-loc-key")]
        public string ActionLocKey { get; set; }

        /// <summary>
        /// （用于多语言支持）指定Localizable.strings文件中相应的key
        /// </summary>
        [JsonProperty("loc-key")]
        public string LocKey { get; set; }

        /// <summary>
        /// 如果loc-key中使用了占位符，则在loc-args中指定各参数
        /// </summary>
        [JsonProperty("loc-args")]
        public IEnumerable<string> LocArgs { get; set; }

        /// <summary>
        /// 指定启动界面图片名
        /// </summary>
        [JsonProperty("launch-image")]
        public string LaunchImage { get; set; }

        /// <summary>
        /// (用于多语言支持）对于标题指定执行按钮所使用的Localizable.strings, 仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty("title-loc-key")]
        public string TitleLocKey { get; set; }

        /// <summary>
        /// 对于标题, 如果loc-key中使用的占位符，则在loc-args中指定各参数, 仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty("title-loc-args")]
        public IEnumerable<string> TitleLocArgs { get; set; }

        /// <summary>
        /// 通知子标题, 仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty("subtitle")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 当前本地化文件中的子标题字符串的关键字, 仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty("subtitle-loc-key")]
        public string SubTitleLocKey { get; set; }

        /// <summary>
        /// 当前本地化子标题内容中需要置换的变量参数, 仅支持iOS8.2以上版本
        /// </summary>
        [JsonProperty("subtitle-loc-args")]
        public IEnumerable<string> SubTitleLocArgs { get; set; }
    }
}
