namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLCOLORSUBTABLEEXTPROC(uint target, int start, int count, uint format, uint type, nint data);
