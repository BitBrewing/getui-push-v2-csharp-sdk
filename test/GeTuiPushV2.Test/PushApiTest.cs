using GeTuiPushV2.Apis;
using GeTuiPushV2.Apis.Dtos;

namespace GeTuiPushV2.Test
{
    public class PushApiTest
    {
        private readonly IPushApi _pushApi;

        public PushApiTest(IPushApi pushApi)
        {
            _pushApi = pushApi;
        }

        [Fact]
        public async Task PushSingleAliasAsync()
        {
            var input = new PushSingleAliasInput
            {
                RequestId = Guid.NewGuid().ToString("N"),
                Audience = new PushAudienceSingleAlias
                {
                    Alias = "s363241620566021",
                },
                Settings = new PushSettings
                {
                    Strategy = new PushSettingsStrategy
                    {
                        Default = 2,
                    },
                },
                PushMessage = new PushMessage
                {
                    Notification = new PushNotification
                    {
                        Title = "标题" + DateTime.Now,
                        Body = "内容" + DateTime.Now,
                        ClickType = PushNotificationClickTypeEnums.StartApp,
                    },
                },
                PushChannel = new PushChannel
                {
                    Android = new PushChannelAndroid
                    {
                        Ups = new PushChannelAndroidUps
                        {
                            Notification = new PushChannelAndroidUpsNotification
                            {
                                Title = "标题" + DateTime.Now,
                                Body = "内容" + DateTime.Now,
                                ClickType = PushChannelAndroidUpsNotificationClickTypeEnums.StartApp,
                            },
                        },
                    },
                },
            };
      
            var result = await _pushApi.PushSingleAliasAsync(input);
            Assert.Equal(0, result.Code);
            Assert.NotNull(result.Data.Cid);
        }

        [Fact]
        public async Task PushAllAsync()
        {
            var input = new PushAllInput
            {
                RequestId = Guid.NewGuid().ToString("N"),
                PushMessage = new PushMessage
                {
                    Notification = new PushNotification
                    {
                        Title = "标题" + DateTime.Now,
                        Body = "内容" + DateTime.Now,
                        ClickType = PushNotificationClickTypeEnums.StartApp,
                    },
                },
            };

            var result = await _pushApi.PushAllAsync(input);
            Assert.Equal(0, result.Code);
            Assert.NotNull(result.Data.TaskId);
        }

        [Fact]
        public async Task PushSingleBatchAliasAsync()
        {
            var input = new PushSingleBatchAliasInput
            {
                MsgList = new PushSingleAliasInput[]
                {
                    new() {
                        RequestId = Guid.NewGuid().ToString("N"),
                        Audience = new PushAudienceSingleAlias
                        {
                            Alias = "s363241620566021",
                        },
                        PushMessage = new PushMessage
                        {
                            Notification = new PushNotification
                            {
                                Title = "标题1" + DateTime.Now,
                                Body = "内容1" + DateTime.Now,
                                ClickType = PushNotificationClickTypeEnums.StartApp,
                            },
                        },
                    },
                    new() {
                        RequestId = Guid.NewGuid().ToString("N"),
                        Audience = new PushAudienceSingleAlias
                        {
                            Alias = "s363241620566021",
                        },
                        PushMessage = new PushMessage
                        {
                            Notification = new PushNotification
                            {
                                Title = "标题2" + DateTime.Now,
                                Body = "内容2" + DateTime.Now,
                                ClickType = PushNotificationClickTypeEnums.StartApp,
                            },
                        },
                    },
                },
            };
            var result = await _pushApi.PushSingleBatchAliasAsync(input);
            Assert.Equal(0, result.Code);
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task PushListMessageAsync()
        {
            var input = new PushListMessageInput
            {
                PushMessage = new PushMessage
                {
                    Notification = new PushNotification
                    {
                        Title = "标题",
                        Body = "内容",
                        ClickType = PushNotificationClickTypeEnums.StartApp,
                    },
                },
            };
            var result = await _pushApi.PushListMessageAsync(input);
            Assert.Equal(0, result.Code);
            Assert.NotNull(result.Data.TaskId);
        }

        [Fact]
        public async Task StopTaskAsync()
        {
            var result = await _pushApi.StopTaskAsync("RASL_0329_76593a2852934143938daa4b841a4a39");
            Assert.Equal(0, result.Code);
        }

        [Fact]
        public async Task PushListAliasAsync()
        {
            var input = new PushListAliasInput
            {
                TaskId = "RASL_0329_76593a2852934143938daa4b841a4a39",
                Audience = new PushAudienceListAlias
                {
                    Alias = new string[] { "s363241620566021" },
                },
            };
            var result = await _pushApi.PushListAliasAsync(input);
            Assert.Equal(0, result.Code);
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task PushFastCustomTagAsync()
        {
            var input = new PushFastCustomTagInput
            {
                RequestId = Guid.NewGuid().ToString("N"),
                Audience = new PushAudienceFastCustomTag
                {
                    FastCustomTag = "role=staff",
                },
                PushMessage = new PushMessage
                {
                    Notification = new PushNotification
                    {
                        Title = "标题2" + DateTime.Now,
                        Body = "内容2" + DateTime.Now,
                        ClickType = PushNotificationClickTypeEnums.StartApp,
                    },
                },
            };
            var result = await _pushApi.PushFastCustomTagAsync(input);
            Assert.Equal(0, result.Code);
            Assert.NotNull(result.Data.TaskId);
        }

        [Fact]
        public async Task PushTagAsyncAsync()
        {
            var input = new PushTagInput
            {
                RequestId = Guid.NewGuid().ToString("N"),
                Audience = new PushAudienceTag
                {
                    Tag = new PushAudienceTagItem[]
                    {
                        new()
                        {
                            Key = PushAudienceTagKeyEnums.CustomTag,
                            Values = new string[]{ "role=staff" },
                            OptType = PushAudienceOptTypeEnums.Or,
                        },
                    },
                },
                PushMessage = new PushMessage
                {
                    Notification = new PushNotification
                    {
                        Title = "标题2" + DateTime.Now,
                        Body = "内容2" + DateTime.Now,
                        ClickType = PushNotificationClickTypeEnums.StartApp,
                    },
                },
            };
            var result = await _pushApi.PushTagAsync(input);
            Assert.Equal(0, result.Code);
        }
    }
}