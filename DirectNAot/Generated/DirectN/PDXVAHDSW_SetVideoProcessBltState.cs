#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_SetVideoProcessBltState(HANDLE hVideoProcessor, DXVAHD_BLT_STATE State, uint DataSize, nint pData);
