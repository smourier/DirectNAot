namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDDENUMVIDEOCALLBACK(nint param0, nint param1);
