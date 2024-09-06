#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videomotionvectorheap
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("5be17987-743a-4061-834b-23d22daea505")]
public partial interface ID3D12VideoMotionVectorHeap : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videomotionvectorheap-getdesc
    [PreserveSig]
    D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC GetDesc();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videomotionvectorheap-getprotectedresourcesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectedResourceSession(in Guid riid, out nint /* void */ ppProtectedSession);
}
