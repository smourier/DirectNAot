namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDIRECTDRAWENUMERATEEXW(nint /*  LPDDENUMCALLBACKEXW */ lpCallback, nint lpContext, uint dwFlags);
