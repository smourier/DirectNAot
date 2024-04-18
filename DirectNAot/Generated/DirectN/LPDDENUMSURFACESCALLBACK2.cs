namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDDENUMSURFACESCALLBACK2(nint /*  IDirectDrawSurface4 */ param0, nint param1, nint param2);
