using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Win32InteropBuilder.Utilities
{
    public interface ILogger
    {
        void Log(TraceLevel level, object? message = null, [CallerMemberName] string? methodName = null);
    }
}
