#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvStartDxInterop(nint param0, [MarshalAs(UnmanagedType.U4)] bool param1, nint KernelModeDeviceHandle);
