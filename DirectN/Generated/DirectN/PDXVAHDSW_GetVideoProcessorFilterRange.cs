#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_GetVideoProcessorFilterRange(HANDLE hDevice, DXVAHD_FILTER Filter, nint pRange);
