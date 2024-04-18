namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLGETPOINTERVEXTPROC(uint pname, nint @params);
