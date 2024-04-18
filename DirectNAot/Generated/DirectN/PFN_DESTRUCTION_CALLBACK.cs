namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DESTRUCTION_CALLBACK(nint pData);
