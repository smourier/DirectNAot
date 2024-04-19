namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_GetVideoProcessBltStatePrivate(HANDLE hVideoProcessor, nint pData);
