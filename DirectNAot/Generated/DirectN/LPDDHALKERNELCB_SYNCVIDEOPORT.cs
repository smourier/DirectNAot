#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALKERNELCB_SYNCVIDEOPORT(nint param0);
