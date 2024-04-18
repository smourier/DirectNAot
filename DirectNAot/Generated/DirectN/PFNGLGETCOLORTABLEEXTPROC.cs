namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLGETCOLORTABLEEXTPROC(uint target, uint format, uint type, nint data);
