namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11videocontext1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("a7f026da-a5f8-4487-a564-15e34357651e")]
public partial interface ID3D11VideoContext1 : ID3D11VideoContext
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-submitdecoderbuffers1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SubmitDecoderBuffers1(ID3D11VideoDecoder pDecoder, uint NumBuffers, [MarshalUsing(CountElementName = nameof(NumBuffers))] in D3D11_VIDEO_DECODER_BUFFER_DESC1[] pBufferDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-getdatafornewhardwarekey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataForNewHardwareKey(ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, nint pPrivatInputData, out ulong pPrivateOutputData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-checkcryptosessionstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCryptoSessionStatus(ID3D11CryptoSession pCryptoSession, out D3D11_CRYPTO_SESSION_STATUS pStatus);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-decoderenabledownsampling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecoderEnableDownsampling(ID3D11VideoDecoder pDecoder, DXGI_COLOR_SPACE_TYPE InputColorSpace, in D3D11_VIDEO_SAMPLE_DESC pOutputDesc, uint ReferenceFrameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-decoderupdatedownsampling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecoderUpdateDownsampling(ID3D11VideoDecoder pDecoder, in D3D11_VIDEO_SAMPLE_DESC pOutputDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetoutputcolorspace1
    [PreserveSig]
    void VideoProcessorSetOutputColorSpace1(ID3D11VideoProcessor pVideoProcessor, DXGI_COLOR_SPACE_TYPE ColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetoutputshaderusage
    [PreserveSig]
    void VideoProcessorSetOutputShaderUsage(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] bool ShaderUsage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetoutputcolorspace1
    [PreserveSig]
    void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor pVideoProcessor, out DXGI_COLOR_SPACE_TYPE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetoutputshaderusage
    [PreserveSig]
    void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor pVideoProcessor, [MarshalAs(UnmanagedType.U4)] out bool pShaderUsage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetstreamcolorspace1
    [PreserveSig]
    void VideoProcessorSetStreamColorSpace1(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, DXGI_COLOR_SPACE_TYPE ColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetstreammirror
    [PreserveSig]
    void VideoProcessorSetStreamMirror(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enable, [MarshalAs(UnmanagedType.U4)] bool FlipHorizontal, [MarshalAs(UnmanagedType.U4)] bool FlipVertical);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetstreamcolorspace1
    [PreserveSig]
    void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out DXGI_COLOR_SPACE_TYPE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetstreammirror
    [PreserveSig]
    void VideoProcessorGetStreamMirror(ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnable, [MarshalAs(UnmanagedType.U4)] out bool pFlipHorizontal, [MarshalAs(UnmanagedType.U4)] out bool pFlipVertical);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetbehaviorhints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VideoProcessorGetBehaviorHints(ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, DXGI_FORMAT OutputFormat, uint StreamCount, [MarshalUsing(CountElementName = nameof(StreamCount))] in D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT[] pStreams, out uint pBehaviorHints);
}
