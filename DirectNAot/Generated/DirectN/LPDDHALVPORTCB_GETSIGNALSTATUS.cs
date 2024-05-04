#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALVPORTCB_GETSIGNALSTATUS(nint param0);
