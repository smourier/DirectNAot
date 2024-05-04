#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvLockDisplayArea(DHPDEV param0, nint param1);
