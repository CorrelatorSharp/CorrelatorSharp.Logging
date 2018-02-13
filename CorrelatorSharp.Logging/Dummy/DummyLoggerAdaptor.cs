using System;

namespace CorrelatorSharp.Logging.Dummy
{
    internal class DummyLoggerAdaptor : ILogger
    {
        public DummyLoggerAdaptor(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name),"Log adaptor must have name.");
        }

        public string Name { get; private set; }

        public bool IsTraceEnabled => true;
        public bool IsWarnEnabled => true;
        public bool IsInfoEnabled => true;
        public bool IsErrorEnabled => true;
        public bool IsFatalEnabled => true;
        public bool IsDebugEnabled => true;

        public void LogError(string format, params object[] values)
        {
        }

        public void LogError(Exception exception, string format = "", params object[] values)
        {
        }

        public void LogFatal(string format, params object[] values)
        {
        }

        public void LogFatal(Exception exception, string format = "", params object[] values)
        {
        }

        public void LogInfo(string format, params object[] values)
        {
        }

        public void LogInfo(Exception exception, string format = "", params object[] values)
        {
        }

        public void LogTrace(string format, params object[] values)
        {
        }

        public void LogTrace(Exception exception, string format = "", params object[] values)
        {
        }

        public void LogWarn(string format, params object[] values)
        {
        }

        public void LogWarn(Exception exception, string format = "", params object[] values)
        {
        }

        public void LogDebug(string format, params object[] values)
        {
        }

        public void LogDebug(Exception exception, string format = "", params object[] values)
        {
        }
    }
}