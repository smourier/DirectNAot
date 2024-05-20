#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PDD_KERNELCB_SYNCSURFACE(nint param0);
