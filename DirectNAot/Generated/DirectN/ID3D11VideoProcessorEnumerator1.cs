namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11videoprocessorenumerator1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("465217f2-5568-43cf-b5b9-f61d54531ca1")]
public partial interface ID3D11VideoProcessorEnumerator1 : ID3D11VideoProcessorEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videoprocessorenumerator1-checkvideoprocessorformatconversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckVideoProcessorFormatConversion(DXGI_FORMAT InputFormat, DXGI_COLOR_SPACE_TYPE InputColorSpace, DXGI_FORMAT OutputFormat, DXGI_COLOR_SPACE_TYPE OutputColorSpace, [MarshalAs(UnmanagedType.U4)] out bool pSupported);
}
