#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALEXEBUFCB_UNLOCKEXEBUF(nint param0);
