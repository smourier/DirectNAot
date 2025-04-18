#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDSENUMCALLBACKW(nint param0, PWSTR param1, PWSTR param2, nint param3);
