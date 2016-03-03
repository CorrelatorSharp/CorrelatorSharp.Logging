using System;
using System.Diagnostics;

namespace CorrelatorSharp.Logging
{
    public static class LogManager
    {
        public static ILogger GetCurrentClassLogger()
        {
            return GetLogger(new StackFrame(1, false).GetMethod().DeclaringType.FullName);
        }

        public static ILogger GetLogger(string name)
        {
            return LoggingConfiguration.LogManager.GetLogger(name);
        }

    }
}
