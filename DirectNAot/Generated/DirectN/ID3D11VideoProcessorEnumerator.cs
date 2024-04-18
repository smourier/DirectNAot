namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videoprocessorenumerator
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("31627037-53ab-4200-9061-05faa9ab45f9")]
public partial interface ID3D11VideoProcessorEnumerator : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessorenumerator-getvideoprocessorcontentdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoProcessorContentDesc(out D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessorenumerator-checkvideoprocessorformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckVideoProcessorFormat(DXGI_FORMAT Format, out uint pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessorenumerator-getvideoprocessorcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoProcessorCaps(out D3D11_VIDEO_PROCESSOR_CAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessorenumerator-getvideoprocessorrateconversioncaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoProcessorRateConversionCaps(uint TypeIndex, out D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessorenumerator-getvideoprocessorcustomrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, out D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessorenumerator-getvideoprocessorfilterrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoProcessorFilterRange(D3D11_VIDEO_PROCESSOR_FILTER Filter, out D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange);
}
