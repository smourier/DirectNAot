#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoprocesscommandlist
[GeneratedComInterface, Guid("aeb2543a-167f-4682-acc8-d159ed4a6209")]
public partial interface ID3D12VideoProcessCommandList : ID3D12CommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(ID3D12CommandAllocator pAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-clearstate
    [PreserveSig]
    void ClearState();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-resourcebarrier
    [PreserveSig]
    void ResourceBarrier(uint NumBarriers, [MarshalUsing(CountElementName = nameof(NumBarriers))] in D3D12_RESOURCE_BARRIER[] pBarriers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-discardresource
    [PreserveSig]
    void DiscardResource(ID3D12Resource pResource, nint /* optional D3D12_DISCARD_REGION* */ pRegion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-beginquery
    [PreserveSig]
    void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-endquery
    [PreserveSig]
    void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-resolvequerydata
    [PreserveSig]
    void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-setpredication
    [PreserveSig]
    void SetPredication(ID3D12Resource? pBuffer, ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-setmarker
    [PreserveSig]
    void SetMarker(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-beginevent
    [PreserveSig]
    void BeginEvent(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-endevent
    [PreserveSig]
    void EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-processframes
    [PreserveSig]
    void ProcessFrames(ID3D12VideoProcessor pVideoProcessor, in D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS pOutputArguments, uint NumInputStreams, [MarshalUsing(CountElementName = nameof(NumInputStreams))] in D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS[] pInputArguments);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist-writebufferimmediate
    [PreserveSig]
    void WriteBufferImmediate(uint Count, [MarshalUsing(CountElementName = nameof(Count))] in D3D12_WRITEBUFFERIMMEDIATE_PARAMETER[] pParams, nint /* optional D3D12_WRITEBUFFERIMMEDIATE_MODE* */ pModes);
}
