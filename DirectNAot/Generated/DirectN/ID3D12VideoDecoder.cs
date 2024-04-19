namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecoder
[GeneratedComInterface, Guid("c59b6bdc-7720-4074-a136-17a156037470")]
public partial interface ID3D12VideoDecoder : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecoder-getdesc
    [PreserveSig]
    D3D12_VIDEO_DECODER_DESC GetDesc();
}
