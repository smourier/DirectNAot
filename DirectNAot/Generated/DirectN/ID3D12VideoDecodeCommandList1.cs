namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecodecommandlist1
[GeneratedComInterface, Guid("d52f011b-b56e-453c-a05a-a7f311c8f472")]
public partial interface ID3D12VideoDecodeCommandList1 : ID3D12VideoDecodeCommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist1-decodeframe1
    [PreserveSig]
    void DecodeFrame1(ID3D12VideoDecoder pDecoder, in D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1 pOutputArguments, in D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS pInputArguments);
}
