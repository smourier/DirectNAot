using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Win32InteropBuilder.Utilities
{
    public class ConsoleLogger : ILogger
    {
        public void Log(TraceLevel level, object? message, [CallerMemberName] string? methodName = null)
        {
            Console.WriteLine(methodName + ":" + message);
        }
    }
}
