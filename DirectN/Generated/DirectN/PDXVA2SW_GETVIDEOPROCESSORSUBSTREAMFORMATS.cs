#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_GETVIDEOPROCESSORSUBSTREAMFORMATS(nint /* in DXVA2_VideoDesc */ pVideoDesc, D3DFORMAT RenderTargetFormat, uint Count, nint pFormats);
