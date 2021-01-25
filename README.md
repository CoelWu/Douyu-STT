<p align="center">
    <img src="https://i.loli.net/2021/01/25/3nWzZm1A5DTNSsQ.png" align="center" height="80"/>
</p>

<div align="center">

# 斗鱼STT .NET SDK

[![Nuget](https://img.shields.io/nuget/v/CoelWu.Douyu.STT)](https://www.nuget.org/packages/CoelWu.Douyu.STT/)

该SDK可以将斗鱼websocket的消息进行序列化和反序列化，在.NET Standard 2.0上构建

</div>

## 简单的开始

使用前，你需要先安装 **CoelWu.Douyu.STT** nuget包

### 1.序列化
```csharp
// 创建Instance
STT data = new STT();

// 添加需要序列化的KeyValuePair
data.Add("type", "loginres");

// 序列化
string rawMessage = data.ToString();
```

### 2.反序列化

```csharp
// 创建Instance
STT data = new STT(rawMessage);

// 获取需要的值
string type = data.Get("type");
```

## 鸣谢
- [SyncPlugin](https://github.com/OsuSync/SyncPlugin)