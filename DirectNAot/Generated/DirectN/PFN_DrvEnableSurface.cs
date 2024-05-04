#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HSURF PFN_DrvEnableSurface(DHPDEV param0);
