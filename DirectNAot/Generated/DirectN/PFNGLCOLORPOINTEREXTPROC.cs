namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLCOLORPOINTEREXTPROC(int size, uint type, int stride, int count, nint pointer);
