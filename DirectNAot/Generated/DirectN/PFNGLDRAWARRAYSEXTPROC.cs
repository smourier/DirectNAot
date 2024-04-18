namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLDRAWARRAYSEXTPROC(uint mode, int first, int count);
