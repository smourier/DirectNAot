#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool LPDDENUMCALLBACKEXW(nint param0, PWSTR param1, PWSTR param2, nint param3, HMONITOR param4);
