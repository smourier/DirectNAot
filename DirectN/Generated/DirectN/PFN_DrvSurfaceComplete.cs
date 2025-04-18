#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvSurfaceComplete(DHPDEV param0, HANDLE param1);
