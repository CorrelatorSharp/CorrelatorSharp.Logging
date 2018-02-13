namespace CorrelatorSharp.Logging
{
    public interface ILogManagerAdaptor
    {
        ILogger GetLogger(string name);
    }
}
