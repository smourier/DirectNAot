namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPCLIPPERCALLBACK(nint /*  IDirectDrawClipper */ lpDDClipper, HWND hWnd, uint code, nint lpContext);
