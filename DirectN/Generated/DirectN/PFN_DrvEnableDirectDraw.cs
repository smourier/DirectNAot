#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvEnableDirectDraw(DHPDEV param0, nint param1, nint param2, nint param3);
