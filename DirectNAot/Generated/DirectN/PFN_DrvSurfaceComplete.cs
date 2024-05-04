#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvSurfaceComplete(DHPDEV param0, HANDLE param1);
