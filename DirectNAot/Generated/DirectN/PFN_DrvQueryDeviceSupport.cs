#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvQueryDeviceSupport(nint param0, nint param1, nint param2, uint param3, uint param4, nint param5, uint param6, nint param7);
