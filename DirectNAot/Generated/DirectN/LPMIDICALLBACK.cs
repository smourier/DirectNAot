#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void LPMIDICALLBACK(HDRVR hdrvr, uint uMsg, nuint dwUser, nuint dw1, nuint dw2);
