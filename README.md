## 安装
```
Install-Package GeTuiPushV2
```

## 注册
```csharp
services
    .AddGeTuiPush(x =>
    {
        x.AppId = "xxx";
        x.AppKey = "xxx";
        x.MasterSecret = "xxx";
    })
    //添加默认日志输出
    //.AddDefaultLogger()
    ;
```

## 使用
推送 API 直接使用即可,系统会自动维护 token
```csharp

private readonly IPushApi _pushApi;

var input = new PushSingleAliasInput
{
    //...
};
var result = await _pushApi.PushSingleAliasAsync(input)
    //如果返回错误,会抛出异常
    .EnsureThrowErrorAsync();
```

## 已完成的 API

|接口名|方法名|类别|功能|
|--|--|--|--|
|IAuthApi|CreateTokenAsync|鉴权API|[获取鉴权](https://docs.getui.com/getui/server/rest_v2/token/#0)|
|IAuthApi|DeleteTokenAsync|鉴权API|[删除鉴权](https://docs.getui.com/getui/server/rest_v2/token/#1)|
|IPushApi|PushSingleCidAsync|推送API|[[toSingle]执行cid单推](https://docs.getui.com/getui/server/rest_v2/push/#1)|
|IPushApi|PushSingleAliasAsync|推送API|[[toSingle]执行别名单推](https://docs.getui.com/getui/server/rest_v2/push/#2)|
|IPushApi|PushSingleBatchCidAsync|推送API|[[toSingle]执行cid批量单推](https://docs.getui.com/getui/server/rest_v2/push/#3)|
|IPushApi|PushSingleBatchAliasAsync|推送API|[[toSingle]执行别名批量单推](https://docs.getui.com/getui/server/rest_v2/push/#4)|
|IPushApi|PushListMessageAsync|推送API|[[toList]创建消息](https://docs.getui.com/getui/server/rest_v2/push/#5)|
|IPushApi|PushListCidAsync|推送API|[[toList]执行cid批量推](https://docs.getui.com/getui/server/rest_v2/push/#6)|
|IPushApi|PushListAliasAsync|推送API|[[toList]执行别名批量推](https://docs.getui.com/getui/server/rest_v2/push/#7)|
|IPushApi|PushAllAsync|推送API|[[toApp]执行群推](https://docs.getui.com/getui/server/rest_v2/push/#8)|
|IPushApi|PushTagAsync|推送API|[[toApp]根据条件筛选用户推送](https://docs.getui.com/getui/server/rest_v2/push/#9)|
|IPushApi|PushFastCustomTagAsync|推送API|[[toApp]使用标签快速推送](https://docs.getui.com/getui/server/rest_v2/push/#10)|
|IPushApi|StopTaskAsync|推送API|[[任务]停止任务](https://docs.getui.com/getui/server/rest_v2/push/#11)|
