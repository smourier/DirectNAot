#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvEndDxInterop(nint param0, [MarshalAs(UnmanagedType.U4)] bool param1, nint param2, nint KernelModeDeviceHandle);
