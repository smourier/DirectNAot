#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALVPORTCB_GETOUTPUTFORMATS(nint param0);
