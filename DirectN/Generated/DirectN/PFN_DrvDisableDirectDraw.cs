#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvDisableDirectDraw(DHPDEV param0);
