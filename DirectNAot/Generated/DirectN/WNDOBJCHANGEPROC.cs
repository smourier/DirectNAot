namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void WNDOBJCHANGEPROC(nint pwo, uint fl);
