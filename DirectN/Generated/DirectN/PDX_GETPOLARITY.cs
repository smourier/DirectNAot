#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PDX_GETPOLARITY(nint param0, nint param1, nint param2);
