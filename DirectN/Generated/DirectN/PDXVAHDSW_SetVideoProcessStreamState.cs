#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_SetVideoProcessStreamState(HANDLE hVideoProcessor, uint StreamNumber, DXVAHD_STREAM_STATE State, uint DataSize, nint pData);
