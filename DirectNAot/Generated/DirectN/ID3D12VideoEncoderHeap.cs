#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoencoderheap
[GeneratedComInterface, Guid("22b35d96-876a-44c0-b25e-fb8c9c7f1c4a")]
public partial interface ID3D12VideoEncoderHeap : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencoderheap-getnodemask
    [PreserveSig]
    uint GetNodeMask();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencoderheap-getencoderheapflags
    [PreserveSig]
    D3D12_VIDEO_ENCODER_HEAP_FLAGS GetEncoderHeapFlags();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencoderheap-getcodec
    [PreserveSig]
    D3D12_VIDEO_ENCODER_CODEC GetCodec();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencoderheap-getcodecprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecProfile(D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencoderheap-getcodeclevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecLevel(D3D12_VIDEO_ENCODER_LEVEL_SETTING dstLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencoderheap-getresolutionlistcount
    [PreserveSig]
    uint GetResolutionListCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencoderheap-getresolutionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResolutionList(uint ResolutionsListCount, [MarshalUsing(CountElementName = nameof(ResolutionsListCount))] out D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC[] pResolutionList);
}
