#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvIcmSetDeviceGammaRamp(DHPDEV param0, uint param1, nint param2);
