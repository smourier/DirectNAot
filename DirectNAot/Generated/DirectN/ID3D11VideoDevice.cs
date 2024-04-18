namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videodevice
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333")]
public partial interface ID3D11VideoDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideodecoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVideoDecoder(in D3D11_VIDEO_DECODER_DESC pVideoDesc, in D3D11_VIDEO_DECODER_CONFIG pConfig, out ID3D11VideoDecoder ppDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVideoProcessor(ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, out ID3D11VideoProcessor ppVideoProcessor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createauthenticatedchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateAuthenticatedChannel(D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, out ID3D11AuthenticatedChannel ppAuthenticatedChannel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createcryptosession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateCryptoSession(in Guid pCryptoType, nint/* nint */ pDecoderProfile, in Guid pKeyExchangeType, out ID3D11CryptoSession ppCryptoSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideodecoderoutputview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVideoDecoderOutputView(ID3D11Resource pResource, in D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc, nint/* nint */ ppVDOVView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessorinputview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVideoProcessorInputView(ID3D11Resource pResource, ID3D11VideoProcessorEnumerator pEnum, in D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc, nint/* nint */ ppVPIView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessoroutputview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVideoProcessorOutputView(ID3D11Resource pResource, ID3D11VideoProcessorEnumerator pEnum, in D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc, nint/* nint */ ppVPOView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessorenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateVideoProcessorEnumerator(in D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc, out ID3D11VideoProcessorEnumerator ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderprofilecount
    [PreserveSig]
    public uint GetVideoDecoderProfileCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoDecoderProfile(uint Index, out Guid pDecoderProfile);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-checkvideodecoderformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckVideoDecoderFormat(in Guid pDecoderProfile, DXGI_FORMAT Format, [MarshalAs(UnmanagedType.U4)] out bool pSupported);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderconfigcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoDecoderConfigCount(in D3D11_VIDEO_DECODER_DESC pDesc, out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVideoDecoderConfig(in D3D11_VIDEO_DECODER_DESC pDesc, uint Index, out D3D11_VIDEO_DECODER_CONFIG pConfig);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getcontentprotectioncaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContentProtectionCaps(nint/* nint */ pCryptoType, nint/* nint */ pDecoderProfile, out D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-checkcryptokeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckCryptoKeyExchange(in Guid pCryptoType, nint/* nint */ pDecoderProfile, uint Index, out Guid pKeyExchangeType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateData(in Guid guid, uint DataSize, nint/* nint */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-setprivatedatainterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateDataInterface(in Guid guid, nint pData);
}
