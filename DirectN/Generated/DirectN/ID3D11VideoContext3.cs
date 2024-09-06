#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_4/nn-d3d11_4-id3d11videocontext3
[GeneratedComInterface, Guid("a9e2faa0-cb39-418f-a0b7-d8aad4de672e")]
public partial interface ID3D11VideoContext3 : ID3D11VideoContext2
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11videocontext3-decoderbeginframe1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecoderBeginFrame1(ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView pView, uint ContentKeySize, nint /* optional void* */ pContentKey, uint NumComponentHistograms, nint /* optional uint* */ pHistogramOffsets, nint /* optional ID3D11Buffer* */ ppHistogramBuffers);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SubmitDecoderBuffers2(ID3D11VideoDecoder pDecoder, uint NumBuffers, [In][MarshalUsing(CountElementName = nameof(NumBuffers))] D3D11_VIDEO_DECODER_BUFFER_DESC2[] pBufferDesc);
}
