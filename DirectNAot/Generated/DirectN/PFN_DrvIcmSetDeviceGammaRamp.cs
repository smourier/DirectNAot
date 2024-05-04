#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvIcmSetDeviceGammaRamp(DHPDEV param0, uint param1, nint param2);
