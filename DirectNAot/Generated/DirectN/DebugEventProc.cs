#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void DebugEventProc(DebugEventLevel level, PSTR message);
