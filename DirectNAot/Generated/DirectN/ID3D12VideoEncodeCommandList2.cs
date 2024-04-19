namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoencodecommandlist2
[GeneratedComInterface, Guid("895491e2-e701-46a9-9a1f-8d3480ed867a")]
public partial interface ID3D12VideoEncodeCommandList2 : ID3D12VideoEncodeCommandList1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist2-encodeframe
    [PreserveSig]
    void EncodeFrame(ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap pHeap, in D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS pInputArguments, in D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS pOutputArguments);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist2-resolveencoderoutputmetadata
    [PreserveSig]
    void ResolveEncoderOutputMetadata(in D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS pInputArguments, in D3D12_VIDEO_ENCODER_RESOLVE_METADATA_OUTPUT_ARGUMENTS pOutputArguments);
}
