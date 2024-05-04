#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GLUtessErrorDataProc(uint param0, nint param1);
