namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_VIDEOPROCESSBLT(HANDLE hDevice, nint /* in DXVA2_VIDEOPROCESSBLT */ pBlt);
