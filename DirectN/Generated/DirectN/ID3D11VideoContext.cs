#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videocontext
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4")]
public partial interface ID3D11VideoContext : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-getdecoderbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderBuffer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, out uint pBufferSize, out nint ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-releasedecoderbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDecoderBuffer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decoderbeginframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecoderBeginFrame([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoderOutputView>))] ID3D11VideoDecoderOutputView pView, uint ContentKeySize, nint /* optional void* */ pContentKey);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decoderendframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecoderEndFrame([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-submitdecoderbuffers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SubmitDecoderBuffers([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, uint NumBuffers, [In][MarshalUsing(CountElementName = nameof(NumBuffers))] D3D11_VIDEO_DECODER_BUFFER_DESC[] pBufferDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decoderextension
    [PreserveSig]
    int DecoderExtension([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, in D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputtargetrect
    [PreserveSig]
    void VideoProcessorSetOutputTargetRect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, BOOL Enable, nint /* optional RECT* */ pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputbackgroundcolor
    [PreserveSig]
    void VideoProcessorSetOutputBackgroundColor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, BOOL YCbCr, in D3D11_VIDEO_COLOR pColor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputcolorspace
    [PreserveSig]
    void VideoProcessorSetOutputColorSpace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, in D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputalphafillmode
    [PreserveSig]
    void VideoProcessorSetOutputAlphaFillMode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, uint StreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputconstriction
    [PreserveSig]
    void VideoProcessorSetOutputConstriction([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, BOOL Enable, SIZE Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputstereomode
    [PreserveSig]
    void VideoProcessorSetOutputStereoMode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, BOOL Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputextension
    [PreserveSig]
    int VideoProcessorSetOutputExtension([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputtargetrect
    [PreserveSig]
    void VideoProcessorGetOutputTargetRect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out BOOL Enabled, out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputbackgroundcolor
    [PreserveSig]
    void VideoProcessorGetOutputBackgroundColor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out BOOL pYCbCr, out D3D11_VIDEO_COLOR pColor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputcolorspace
    [PreserveSig]
    void VideoProcessorGetOutputColorSpace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputalphafillmode
    [PreserveSig]
    void VideoProcessorGetOutputAlphaFillMode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, out uint pStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputconstriction
    [PreserveSig]
    void VideoProcessorGetOutputConstriction([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out BOOL pEnabled, out SIZE pSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputstereomode
    [PreserveSig]
    void VideoProcessorGetOutputStereoMode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out BOOL pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputextension
    [PreserveSig]
    int VideoProcessorGetOutputExtension([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamframeformat
    [PreserveSig]
    void VideoProcessorSetStreamFrameFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamcolorspace
    [PreserveSig]
    void VideoProcessorSetStreamColorSpace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, in D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamoutputrate
    [PreserveSig]
    void VideoProcessorSetStreamOutputRate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, BOOL RepeatFrame, nint /* optional DXGI_RATIONAL* */ pCustomRate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamsourcerect
    [PreserveSig]
    void VideoProcessorSetStreamSourceRect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, nint /* optional RECT* */ pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamdestrect
    [PreserveSig]
    void VideoProcessorSetStreamDestRect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, nint /* optional RECT* */ pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamalpha
    [PreserveSig]
    void VideoProcessorSetStreamAlpha([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, float Alpha);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreampalette
    [PreserveSig]
    void VideoProcessorSetStreamPalette([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, nint /* optional uint* */ pEntries);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreampixelaspectratio
    [PreserveSig]
    void VideoProcessorSetStreamPixelAspectRatio([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, nint /* optional DXGI_RATIONAL* */ pSourceAspectRatio, nint /* optional DXGI_RATIONAL* */ pDestinationAspectRatio);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamlumakey
    [PreserveSig]
    void VideoProcessorSetStreamLumaKey([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, float Lower, float Upper);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamstereoformat
    [PreserveSig]
    void VideoProcessorSetStreamStereoFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, BOOL LeftViewFrame0, BOOL BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamautoprocessingmode
    [PreserveSig]
    void VideoProcessorSetStreamAutoProcessingMode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamfilter
    [PreserveSig]
    void VideoProcessorSetStreamFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL Enable, int Level);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamextension
    [PreserveSig]
    int VideoProcessorSetStreamExtension([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamframeformat
    [PreserveSig]
    void VideoProcessorGetStreamFrameFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamcolorspace
    [PreserveSig]
    void VideoProcessorGetStreamColorSpace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamoutputrate
    [PreserveSig]
    void VideoProcessorGetStreamOutputRate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, out BOOL pRepeatFrame, out DXGI_RATIONAL pCustomRate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamsourcerect
    [PreserveSig]
    void VideoProcessorGetStreamSourceRect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnabled, out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamdestrect
    [PreserveSig]
    void VideoProcessorGetStreamDestRect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnabled, out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamalpha
    [PreserveSig]
    void VideoProcessorGetStreamAlpha([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnabled, out float pAlpha);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreampalette
    [PreserveSig]
    void VideoProcessorGetStreamPalette([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, [In][Out][MarshalUsing(CountElementName = nameof(Count))] uint[] pEntries);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreampixelaspectratio
    [PreserveSig]
    void VideoProcessorGetStreamPixelAspectRatio([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnabled, out DXGI_RATIONAL pSourceAspectRatio, out DXGI_RATIONAL pDestinationAspectRatio);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamlumakey
    [PreserveSig]
    void VideoProcessorGetStreamLumaKey([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnabled, out float pLower, out float pUpper);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamstereoformat
    [PreserveSig]
    void VideoProcessorGetStreamStereoFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnable, out D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, out BOOL pLeftViewFrame0, out BOOL pBaseViewFrame0, out D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, out int MonoOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamautoprocessingmode
    [PreserveSig]
    void VideoProcessorGetStreamAutoProcessingMode([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamfilter
    [PreserveSig]
    void VideoProcessorGetStreamFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, out BOOL pEnabled, out int pLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamextension
    [PreserveSig]
    int VideoProcessorGetStreamExtension([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorblt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VideoProcessorBlt([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessorOutputView>))] ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, [In][MarshalUsing(CountElementName = nameof(StreamCount))] D3D11_VIDEO_PROCESSOR_STREAM[] pStreams);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-negotiatecryptosessionkeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NegotiateCryptoSessionKeyExchange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-encryptionblt
    [PreserveSig]
    void EncryptionBlt([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Texture2D>))] ID3D11Texture2D pSrcSurface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Texture2D>))] ID3D11Texture2D pDstSurface, uint IVSize, nint /* optional void* */ pIV);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decryptionblt
    [PreserveSig]
    void DecryptionBlt([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Texture2D>))] ID3D11Texture2D pSrcSurface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Texture2D>))] ID3D11Texture2D pDstSurface, nint /* optional D3D11_ENCRYPTED_BLOCK_INFO* */ pEncryptedBlockInfo, uint ContentKeySize, nint /* optional void* */ pContentKey, uint IVSize, nint /* optional void* */ pIV);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-startsessionkeyrefresh
    [PreserveSig]
    void StartSessionKeyRefresh([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, nint pRandomNumber);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-finishsessionkeyrefresh
    [PreserveSig]
    void FinishSessionKeyRefresh([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-getencryptionbltkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEncryptionBltKey([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession, uint KeySize, nint pReadbackKey);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-negotiateauthenticatedchannelkeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NegotiateAuthenticatedChannelKeyExchange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11AuthenticatedChannel>))] ID3D11AuthenticatedChannel pChannel, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-queryauthenticatedchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryAuthenticatedChannel([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11AuthenticatedChannel>))] ID3D11AuthenticatedChannel pChannel, uint InputSize, nint pInput, uint OutputSize, nint pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-configureauthenticatedchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfigureAuthenticatedChannel([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11AuthenticatedChannel>))] ID3D11AuthenticatedChannel pChannel, uint InputSize, nint pInput, out D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamrotation
    [PreserveSig]
    void VideoProcessorSetStreamRotation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamrotation
    [PreserveSig]
    void VideoProcessorGetStreamRotation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnable, out D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
}
