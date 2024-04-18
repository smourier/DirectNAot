namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLGETCOLORTABLEPARAMETERFVEXTPROC(uint target, uint pname, nint @params);
