namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void MFPERIODICCALLBACK(nint /* nint */ pContext);
