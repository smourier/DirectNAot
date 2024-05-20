#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLGETCOLORTABLEPARAMETERIVEXTPROC(uint target, uint pname, nint @params);
