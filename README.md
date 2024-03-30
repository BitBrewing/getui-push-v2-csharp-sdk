## 安装
```
Install-Package GeTuiPushV2
```

### 注册
```csharp
services
    .AddGeTuiPush(x =>
    {
        x.AppId = "xxx";
        x.AppKey = "xxx";
        x.MasterSecret = "xxx";
    });
```

### 使用
```csharp

private readonly IPushApi _pushApi;

var input = new PushSingleAliasInput
{
    //...
};
var result = await _pushApi.PushSingleAliasAsync(input).EnsureThrowErrorAsync();
```