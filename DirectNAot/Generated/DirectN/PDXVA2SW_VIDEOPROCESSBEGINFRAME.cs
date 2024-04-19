namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_VIDEOPROCESSBEGINFRAME(HANDLE hDevice);
