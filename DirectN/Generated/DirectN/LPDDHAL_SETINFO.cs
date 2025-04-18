#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPDDHAL_SETINFO(nint lpDDHalInfo, BOOL reset);
