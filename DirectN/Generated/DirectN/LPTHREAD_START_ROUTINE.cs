#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPTHREAD_START_ROUTINE(nint lpThreadParameter);
