#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALVPORTCB_CREATEVIDEOPORT(nint param0);
