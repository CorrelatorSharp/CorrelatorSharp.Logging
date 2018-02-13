using System;

namespace CorrelatorSharp.Logging
{
    public class LoggingConfiguration
    {
        public static readonly LoggingConfiguration Current = new LoggingConfiguration();

        private static readonly Lazy<ILogManagerAdaptor> DummyLogManager = 
            new Lazy<ILogManagerAdaptor>(() => Dummy.DummyLogManagerAdaptor.Instance);
        
        private static ILogManagerAdaptor _logManager;

        internal static ILogManagerAdaptor LogManager
        {
            get => _logManager ?? DummyLogManager.Value;
            set => _logManager = value;
        }
    }
}
