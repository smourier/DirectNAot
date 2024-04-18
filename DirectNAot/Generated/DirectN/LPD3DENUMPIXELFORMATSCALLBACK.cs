namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPD3DENUMPIXELFORMATSCALLBACK(nint lpDDPixFmt, nint lpContext);
