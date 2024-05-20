#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HBITMAP PFN_DrvDeriveSurface(nint param0, nint param1);
