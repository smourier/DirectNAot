#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PDD_VPORTCB_CANCREATEVIDEOPORT(nint param0);
