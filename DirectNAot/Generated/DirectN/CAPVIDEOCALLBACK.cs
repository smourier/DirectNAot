namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT CAPVIDEOCALLBACK(HWND hWnd, nint /* in VIDEOHDR */ lpVHdr);
