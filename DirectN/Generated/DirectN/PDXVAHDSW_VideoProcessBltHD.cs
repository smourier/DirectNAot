#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_VideoProcessBltHD(HANDLE hVideoProcessor, nint /* IDirect3DSurface9 */ pOutputSurface, uint OutputFrame, uint StreamCount, nint /* in DXVAHD_STREAM_DATA */ pStreams);
