namespace CorrelatorSharp.Logging
{
    public static class LoggingConfigurationExtensions
    {
        public static LoggingConfiguration WithLogManager(this LoggingConfiguration config, ILogManagerAdaptor adapter)
        {
            LoggingConfiguration.LogManager = adapter;
            return config;
        }
    }

}
