#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvIcmSetDeviceGammaRamp(DHPDEV param0, uint param1, nint param2);
