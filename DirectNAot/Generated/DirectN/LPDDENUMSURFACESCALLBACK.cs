namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPDDENUMSURFACESCALLBACK(nint /* IDirectDrawSurface */ param0, nint param1, nint param2);
