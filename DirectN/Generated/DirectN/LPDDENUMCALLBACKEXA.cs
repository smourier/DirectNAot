#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDDENUMCALLBACKEXA(nint param0, PSTR param1, PSTR param2, nint param3, HMONITOR param4);
