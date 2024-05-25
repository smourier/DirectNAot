#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint EDITSTREAMCALLBACK(nuint dwCookie, nint pbBuff, int cb, nint pcb);
