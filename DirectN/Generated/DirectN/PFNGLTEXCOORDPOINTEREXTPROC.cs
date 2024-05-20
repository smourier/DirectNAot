#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLTEXCOORDPOINTEREXTPROC(int size, uint type, int stride, int count, nint pointer);
