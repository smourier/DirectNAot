namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPD3DENUMTEXTUREFORMATSCALLBACK(nint lpDdsd, nint lpContext);
