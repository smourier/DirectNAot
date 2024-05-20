#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLVERTEXPOINTEREXTPROC(int size, uint type, int stride, int count, nint pointer);
