#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void GLUtessVertexDataProc(nint param0, nint param1);
