namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLNORMALPOINTEREXTPROC(uint type, int stride, int count, nint pointer);
