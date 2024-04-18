namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDDENUMMODESCALLBACK(nint param0, nint param1);
