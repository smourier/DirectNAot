#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PDD_SURFCB_GETFLIPSTATUS(nint param0);
