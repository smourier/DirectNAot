#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool LPDSENUMCALLBACKW(nint param0, PWSTR param1, PWSTR param2, nint param3);
