namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool FREEOBJPROC(nint pDriverObj);
