namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDIRECTDRAWENUMERATEEXA(nint /*  LPDDENUMCALLBACKEXA */ lpCallback, nint lpContext, uint dwFlags);
