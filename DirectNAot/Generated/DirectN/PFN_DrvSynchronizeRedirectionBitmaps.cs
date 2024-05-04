#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate NTSTATUS PFN_DrvSynchronizeRedirectionBitmaps(DHPDEV param0, nint param1);
