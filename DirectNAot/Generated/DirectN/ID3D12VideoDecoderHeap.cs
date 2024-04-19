namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecoderheap
[GeneratedComInterface, Guid("0946b7c9-ebf6-4047-bb73-8683e27dbb1f")]
public partial interface ID3D12VideoDecoderHeap : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecoderheap-getdesc
    [PreserveSig]
    D3D12_VIDEO_DECODER_HEAP_DESC GetDesc();
}
