## What is this?

Creating a log entry (`logger.LogTrace("something")`) and actually persisting it are separate operations which can execute in different contexts (threads or processes). We do need to capture the current activity info at the point of creating the log entry and unfortunately frameworks such as NLog doesn't expose a generic way to do that.

To workaround this limitation CorrelatorSharp.Logging provides an `ILogger` and `LogManager` which are practically equivalent to what you will find in most logging frameworks and introduces an adapter model. This enables dropping in Correlatorsharp.Logging and removing direct references to e.g. NLog without having to do code changes other than a namespace change.

For further information: [CorrelatorSharp](http://correlatorsharp.github.io). 

## Get it

|   Where    |    What   |
|-------------|-------------|
| NuGet       | [CorrelatorSharp.Logging](https://www.nuget.org/packages/CorrelatorSharp.Logging/)
| Latest Build (master)      |   [![Build status](https://ci.appveyor.com/api/projects/status/hab5qmvc6iv0oy46/branch/master?svg=true)](https://ci.appveyor.com/project/CorrelatorSharp/correlatorsharp-logging/branch/master)  |


## Implementing a CorrelatorSharp.Logging adapter

*Tip:* Havea look at the [NLog adapter](https://github.com/CorrelatorSharp/CorrelatorSharp.Logging.NLog) for an example.

1. Implement the `ILogger` interface and use `ActivityScope.Current` to capture the current activity scope's correlation id.
2. Implement the `ILogManagerAdaptor` to create ILogger-s.
3. Add a `UseXXXXX` extension method on `LoggingConfiguration` to enable users to configure CorrelatorSharp.Logging to use your framework.

```csharp
public static LoggingConfiguration UseNLog(this LoggingConfiguration config)
{
    config.WithLogManager(new MyNewLoggingFrameworkLogManagerAdaptor());
    return config;
}
```