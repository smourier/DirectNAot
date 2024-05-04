#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11videodevice1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("29da1d51-1321-4454-804b-f5fc9f861f0f")]
public partial interface ID3D11VideoDevice1 : ID3D11VideoDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videodevice1-getcryptosessionprivatedatasize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCryptoSessionPrivateDataSize(in Guid pCryptoType, nint /* optional Guid* */ pDecoderProfile, in Guid pKeyExchangeType, out uint pPrivateInputSize, out uint pPrivateOutputSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videodevice1-getvideodecodercaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoDecoderCaps(in Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, in DXGI_RATIONAL pFrameRate, uint BitRate, nint /* optional Guid* */ pCryptoType, out uint pDecoderCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videodevice1-checkvideodecoderdownsampling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckVideoDecoderDownsampling(in D3D11_VIDEO_DECODER_DESC pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, in D3D11_VIDEO_DECODER_CONFIG pInputConfig, in DXGI_RATIONAL pFrameRate, in D3D11_VIDEO_SAMPLE_DESC pOutputDesc, [MarshalAs(UnmanagedType.U4)] out bool pSupported, [MarshalAs(UnmanagedType.U4)] out bool pRealTimeHint);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videodevice1-recommendvideodecoderdownsampleparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecommendVideoDecoderDownsampleParameters(in D3D11_VIDEO_DECODER_DESC pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, in D3D11_VIDEO_DECODER_CONFIG pInputConfig, in DXGI_RATIONAL pFrameRate, out D3D11_VIDEO_SAMPLE_DESC pRecommendedOutputDesc);
}
