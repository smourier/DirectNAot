#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoencodecommandlist
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("8455293a-0cbd-4831-9b39-fbdbab724723")]
public partial interface ID3D12VideoEncodeCommandList : ID3D12CommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(ID3D12CommandAllocator pAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-clearstate
    [PreserveSig]
    void ClearState();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-resourcebarrier
    [PreserveSig]
    void ResourceBarrier(uint NumBarriers, [In][MarshalUsing(CountElementName = nameof(NumBarriers))] D3D12_RESOURCE_BARRIER[] pBarriers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-discardresource
    [PreserveSig]
    void DiscardResource(ID3D12Resource pResource, nint /* optional D3D12_DISCARD_REGION* */ pRegion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-beginquery
    [PreserveSig]
    void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-endquery
    [PreserveSig]
    void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-resolvequerydata
    [PreserveSig]
    void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-setpredication
    [PreserveSig]
    void SetPredication(ID3D12Resource? pBuffer, ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-setmarker
    [PreserveSig]
    void SetMarker(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-beginevent
    [PreserveSig]
    void BeginEvent(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-endevent
    [PreserveSig]
    void EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-estimatemotion
    [PreserveSig]
    void EstimateMotion(ID3D12VideoMotionEstimator pMotionEstimator, in D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT pOutputArguments, in D3D12_VIDEO_MOTION_ESTIMATOR_INPUT pInputArguments);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-resolvemotionvectorheap
    [PreserveSig]
    void ResolveMotionVectorHeap(in D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT pOutputArguments, in D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT pInputArguments);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-writebufferimmediate
    [PreserveSig]
    void WriteBufferImmediate(uint Count, [In][MarshalUsing(CountElementName = nameof(Count))] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER[] pParams, nint /* optional D3D12_WRITEBUFFERIMMEDIATE_MODE* */ pModes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist-setprotectedresourcesession
    [PreserveSig]
    void SetProtectedResourceSession(ID3D12ProtectedResourceSession? pProtectedResourceSession);
}
