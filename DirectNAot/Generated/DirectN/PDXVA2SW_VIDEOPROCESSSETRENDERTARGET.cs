namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_VIDEOPROCESSSETRENDERTARGET(HANDLE hDevice, nint /* IDirect3DSurface9 */ pRenderTarget);
