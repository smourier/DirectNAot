#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvEndDxInterop(nint param0, BOOL param1, nint param2, nint KernelModeDeviceHandle);
