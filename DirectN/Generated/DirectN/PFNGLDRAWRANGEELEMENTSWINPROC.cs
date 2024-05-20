#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLDRAWRANGEELEMENTSWINPROC(uint mode, uint start, uint end, int count, uint type, nint indices);
