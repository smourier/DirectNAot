#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALVPORTCB_GETBANDWIDTH(nint param0);
