namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_GetVideoProcessStreamStatePrivate(HANDLE hVideoProcessor, uint StreamNumber, nint pData);
