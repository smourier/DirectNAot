#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDDENUMCALLBACKEXW(nint param0, PWSTR param1, PWSTR param2, nint param3, HMONITOR param4);
