#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALVPORTCB_GETVPORTCONNECT(nint param0);
