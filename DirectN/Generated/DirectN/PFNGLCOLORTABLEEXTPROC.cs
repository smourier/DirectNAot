#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLCOLORTABLEEXTPROC(uint target, uint internalFormat, int width, uint format, uint type, nint data);
