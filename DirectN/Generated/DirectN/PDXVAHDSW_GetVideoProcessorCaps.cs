#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_GetVideoProcessorCaps(HANDLE hDevice, nint /* in DXVAHD_CONTENT_DESC */ pContentDesc, DXVAHD_DEVICE_USAGE Usage, uint Count, nint pCaps);
