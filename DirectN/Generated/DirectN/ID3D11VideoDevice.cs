#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videodevice
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333")]
public partial interface ID3D11VideoDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideodecoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoDecoder(in D3D11_VIDEO_DECODER_DESC pVideoDesc, in D3D11_VIDEO_DECODER_CONFIG pConfig, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] out ID3D11VideoDecoder ppDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessor(ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] out ID3D11VideoProcessor ppVideoProcessor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createauthenticatedchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAuthenticatedChannel(D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11AuthenticatedChannel>))] out ID3D11AuthenticatedChannel ppAuthenticatedChannel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createcryptosession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCryptoSession(in Guid pCryptoType, nint /* optional Guid* */ pDecoderProfile, in Guid pKeyExchangeType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] out ID3D11CryptoSession ppCryptoSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideodecoderoutputview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoDecoderOutputView(ID3D11Resource pResource, in D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc, nint /* optional ID3D11VideoDecoderOutputView* */ ppVDOVView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessorinputview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessorInputView(ID3D11Resource pResource, ID3D11VideoProcessorEnumerator pEnum, in D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc, nint /* optional ID3D11VideoProcessorInputView* */ ppVPIView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessoroutputview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessorOutputView(ID3D11Resource pResource, ID3D11VideoProcessorEnumerator pEnum, in D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc, nint /* optional ID3D11VideoProcessorOutputView* */ ppVPOView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-createvideoprocessorenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessorEnumerator(in D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessorEnumerator>))] out ID3D11VideoProcessorEnumerator ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderprofilecount
    [PreserveSig]
    uint GetVideoDecoderProfileCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoDecoderProfile(uint Index, out Guid pDecoderProfile);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-checkvideodecoderformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckVideoDecoderFormat(in Guid pDecoderProfile, DXGI_FORMAT Format, out BOOL pSupported);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderconfigcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoDecoderConfigCount(in D3D11_VIDEO_DECODER_DESC pDesc, out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getvideodecoderconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoDecoderConfig(in D3D11_VIDEO_DECODER_DESC pDesc, uint Index, out D3D11_VIDEO_DECODER_CONFIG pConfig);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-getcontentprotectioncaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentProtectionCaps(nint /* optional Guid* */ pCryptoType, nint /* optional Guid* */ pDecoderProfile, out D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-checkcryptokeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCryptoKeyExchange(in Guid pCryptoType, nint /* optional Guid* */ pDecoderProfile, uint Index, out Guid pKeyExchangeType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid guid, uint DataSize, nint /* optional void* */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videodevice-setprivatedatainterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateDataInterface(in Guid guid, nint pData);
}
