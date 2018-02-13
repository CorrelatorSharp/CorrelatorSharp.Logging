namespace CorrelatorSharp.Logging.Dummy
{
    internal class DummyLogManagerAdaptor : ILogManagerAdaptor
    {
        public readonly static DummyLogManagerAdaptor Instance = new DummyLogManagerAdaptor();

        public ILogger GetLogger(string name) =>
            new DummyLoggerAdaptor(name);
    }
}
