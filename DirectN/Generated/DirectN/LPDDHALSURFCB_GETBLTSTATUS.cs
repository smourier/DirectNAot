#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPDDHALSURFCB_GETBLTSTATUS(nint param0);
