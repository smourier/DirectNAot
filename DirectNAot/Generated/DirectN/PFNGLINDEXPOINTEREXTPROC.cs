namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLINDEXPOINTEREXTPROC(uint type, int stride, int count, nint pointer);
