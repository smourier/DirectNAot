namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPD3DVALIDATECALLBACK(nint lpUserArg, uint dwOffset);
