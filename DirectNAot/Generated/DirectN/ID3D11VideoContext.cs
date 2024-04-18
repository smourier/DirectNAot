namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11videocontext
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4")]
public partial interface ID3D11VideoContext : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-getdecoderbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDecoderBuffer(ID3D11VideoDecoder pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, out uint pBufferSize, out nint ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-releasedecoderbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReleaseDecoderBuffer(ID3D11VideoDecoder pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decoderbeginframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DecoderBeginFrame(ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView pView, uint ContentKeySize, nint/* nint */ pContentKey);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decoderendframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DecoderEndFrame(ID3D11VideoDecoder pDecoder);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-submitdecoderbuffers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SubmitDecoderBuffers(ID3D11VideoDecoder pDecoder, uint NumBuffers, in D3D11_VIDEO_DECODER_BUFFER_DESC pBufferDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decoderextension
    [PreserveSig]
    public int DecoderExtension(ID3D11VideoDecoder pDecoder, in D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputtargetrect
    [PreserveSig]
    public void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] bool Enable, nint/* nint */ pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputbackgroundcolor
    [PreserveSig]
    public void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] bool YCbCr, in D3D11_VIDEO_COLOR pColor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputcolorspace
    [PreserveSig]
    public void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor pVideoProcessor, in D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputalphafillmode
    [PreserveSig]
    public void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, uint StreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputconstriction
    [PreserveSig]
    public void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] bool Enable, in FoundationSIZE Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputstereomode
    [PreserveSig]
    public void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] bool Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetoutputextension
    [PreserveSig]
    public int VideoProcessorSetOutputExtension(ID3D11VideoProcessor pVideoProcessor, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputtargetrect
    [PreserveSig]
    public void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] out bool Enabled, out FoundationRECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputbackgroundcolor
    [PreserveSig]
    public void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] out bool pYCbCr, out D3D11_VIDEO_COLOR pColor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputcolorspace
    [PreserveSig]
    public void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor pVideoProcessor, out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputalphafillmode
    [PreserveSig]
    public void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor pVideoProcessor, out D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, out uint pStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputconstriction
    [PreserveSig]
    public void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] out bool pEnabled, out FoundationSIZE pSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputstereomode
    [PreserveSig]
    public void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] out bool pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetoutputextension
    [PreserveSig]
    public int VideoProcessorGetOutputExtension(ID3D11VideoProcessor pVideoProcessor, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamframeformat
    [PreserveSig]
    public void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamcolorspace
    [PreserveSig]
    public void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, in D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamoutputrate
    [PreserveSig]
    public void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, [MarshalAs(UnmanagedType.U4)] bool RepeatFrame, nint/* nint */ pCustomRate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamsourcerect
    [PreserveSig]
    public void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, nint/* nint */ pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamdestrect
    [PreserveSig]
    public void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, nint/* nint */ pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamalpha
    [PreserveSig]
    public void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, float Alpha);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreampalette
    [PreserveSig]
    public void VideoProcessorSetStreamPalette(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, nint/* nint */ pEntries);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreampixelaspectratio
    [PreserveSig]
    public void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, nint/* nint */ pSourceAspectRatio, nint/* nint */ pDestinationAspectRatio);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamlumakey
    [PreserveSig]
    public void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, float Lower, float Upper);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamstereoformat
    [PreserveSig]
    public void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, [MarshalAs(UnmanagedType.U4)] bool LeftViewFrame0, [MarshalAs(UnmanagedType.U4)] bool BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamautoprocessingmode
    [PreserveSig]
    public void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamfilter
    [PreserveSig]
    public void VideoProcessorSetStreamFilter(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [MarshalAs(UnmanagedType.U4)] bool Enable, int Level);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamextension
    [PreserveSig]
    public int VideoProcessorSetStreamExtension(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamframeformat
    [PreserveSig]
    public void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamcolorspace
    [PreserveSig]
    public void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamoutputrate
    [PreserveSig]
    public void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, [MarshalAs(UnmanagedType.U4)] out bool pRepeatFrame, out DXGI_RATIONAL pCustomRate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamsourcerect
    [PreserveSig]
    public void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled, out FoundationRECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamdestrect
    [PreserveSig]
    public void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled, out FoundationRECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamalpha
    [PreserveSig]
    public void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled, out float pAlpha);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreampalette
    [PreserveSig]
    public void VideoProcessorGetStreamPalette(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, out uint pEntries);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreampixelaspectratio
    [PreserveSig]
    public void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled, out DXGI_RATIONAL pSourceAspectRatio, out DXGI_RATIONAL pDestinationAspectRatio);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamlumakey
    [PreserveSig]
    public void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled, out float pLower, out float pUpper);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamstereoformat
    [PreserveSig]
    public void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnable, out D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, [MarshalAs(UnmanagedType.U4)] out bool pLeftViewFrame0, [MarshalAs(UnmanagedType.U4)] out bool pBaseViewFrame0, out D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, out int MonoOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamautoprocessingmode
    [PreserveSig]
    public void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamfilter
    [PreserveSig]
    public void VideoProcessorGetStreamFilter(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, [MarshalAs(UnmanagedType.U4)] out bool pEnabled, out int pLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamextension
    [PreserveSig]
    public int VideoProcessorGetStreamExtension(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, in Guid pExtensionGuid, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorblt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT VideoProcessorBlt(ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, in D3D11_VIDEO_PROCESSOR_STREAM pStreams);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-negotiatecryptosessionkeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession pCryptoSession, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-encryptionblt
    [PreserveSig]
    public void EncryptionBlt(ID3D11CryptoSession pCryptoSession, ID3D11Texture2D pSrcSurface, ID3D11Texture2D pDstSurface, uint IVSize, nint/* nint */ pIV);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-decryptionblt
    [PreserveSig]
    public void DecryptionBlt(ID3D11CryptoSession pCryptoSession, ID3D11Texture2D pSrcSurface, ID3D11Texture2D pDstSurface, nint/* nint */ pEncryptedBlockInfo, uint ContentKeySize, nint/* nint */ pContentKey, uint IVSize, nint/* nint */ pIV);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-startsessionkeyrefresh
    [PreserveSig]
    public void StartSessionKeyRefresh(ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, nint pRandomNumber);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-finishsessionkeyrefresh
    [PreserveSig]
    public void FinishSessionKeyRefresh(ID3D11CryptoSession pCryptoSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-getencryptionbltkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEncryptionBltKey(ID3D11CryptoSession pCryptoSession, uint KeySize, nint pReadbackKey);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-negotiateauthenticatedchannelkeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel pChannel, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-queryauthenticatedchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryAuthenticatedChannel(ID3D11AuthenticatedChannel pChannel, uint InputSize, nint pInput, uint OutputSize, nint pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-configureauthenticatedchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel pChannel, uint InputSize, nint pInput, out D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorsetstreamrotation
    [PreserveSig]
    public void VideoProcessorSetStreamRotation(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11videocontext-videoprocessorgetstreamrotation
    [PreserveSig]
    public void VideoProcessorGetStreamRotation(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnable, out D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
}
