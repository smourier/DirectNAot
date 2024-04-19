namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videoprocessor
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("1d7b0652-185f-41c6-85ce-0c5be3d4ae6c")]
public partial interface ID3D11VideoProcessor : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessor-getcontentdesc
    [PreserveSig]
    void GetContentDesc(out D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videoprocessor-getrateconversioncaps
    [PreserveSig]
    void GetRateConversionCaps(out D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
}
