#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PDX_LOCK(nint param0, nint param1, nint param2);
