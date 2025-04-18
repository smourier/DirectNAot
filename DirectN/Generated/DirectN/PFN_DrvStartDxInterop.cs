#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvStartDxInterop(nint param0, BOOL param1, nint KernelModeDeviceHandle);
