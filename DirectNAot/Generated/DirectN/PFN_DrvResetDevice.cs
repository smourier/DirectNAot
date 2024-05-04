#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvResetDevice(DHPDEV param0, nint param1);
