#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11videocontext1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("a7f026da-a5f8-4487-a564-15e34357651e")]
public partial interface ID3D11VideoContext1 : ID3D11VideoContext
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-submitdecoderbuffers1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SubmitDecoderBuffers1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, uint NumBuffers, [In][MarshalUsing(CountElementName = nameof(NumBuffers))] D3D11_VIDEO_DECODER_BUFFER_DESC1[] pBufferDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-getdatafornewhardwarekey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataForNewHardwareKey([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, nint pPrivatInputData, out ulong pPrivateOutputData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-checkcryptosessionstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCryptoSessionStatus([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11CryptoSession>))] ID3D11CryptoSession pCryptoSession, out D3D11_CRYPTO_SESSION_STATUS pStatus);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-decoderenabledownsampling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecoderEnableDownsampling([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, DXGI_COLOR_SPACE_TYPE InputColorSpace, in D3D11_VIDEO_SAMPLE_DESC pOutputDesc, uint ReferenceFrameCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-decoderupdatedownsampling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecoderUpdateDownsampling([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoDecoder>))] ID3D11VideoDecoder pDecoder, in D3D11_VIDEO_SAMPLE_DESC pOutputDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetoutputcolorspace1
    [PreserveSig]
    void VideoProcessorSetOutputColorSpace1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, DXGI_COLOR_SPACE_TYPE ColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetoutputshaderusage
    [PreserveSig]
    void VideoProcessorSetOutputShaderUsage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, BOOL ShaderUsage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetoutputcolorspace1
    [PreserveSig]
    void VideoProcessorGetOutputColorSpace1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out DXGI_COLOR_SPACE_TYPE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetoutputshaderusage
    [PreserveSig]
    void VideoProcessorGetOutputShaderUsage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, out BOOL pShaderUsage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetstreamcolorspace1
    [PreserveSig]
    void VideoProcessorSetStreamColorSpace1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, DXGI_COLOR_SPACE_TYPE ColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorsetstreammirror
    [PreserveSig]
    void VideoProcessorSetStreamMirror([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, BOOL Enable, BOOL FlipHorizontal, BOOL FlipVertical);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetstreamcolorspace1
    [PreserveSig]
    void VideoProcessorGetStreamColorSpace1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out DXGI_COLOR_SPACE_TYPE pColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetstreammirror
    [PreserveSig]
    void VideoProcessorGetStreamMirror([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, out BOOL pEnable, out BOOL pFlipHorizontal, out BOOL pFlipVertical);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11videocontext1-videoprocessorgetbehaviorhints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VideoProcessorGetBehaviorHints([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11VideoProcessor>))] ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, DXGI_FORMAT OutputFormat, uint StreamCount, [In][MarshalUsing(CountElementName = nameof(StreamCount))] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT[] pStreams, out uint pBehaviorHints);
}
