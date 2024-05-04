#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GLUtessEdgeFlagDataProc(byte param0, nint param1);
