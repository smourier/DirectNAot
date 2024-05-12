#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecodecommandlist
[GeneratedComInterface, Guid("3b60536e-ad29-4e64-a269-f853837e5e53")]
public partial interface ID3D12VideoDecodeCommandList : ID3D12CommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(ID3D12CommandAllocator pAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-clearstate
    [PreserveSig]
    void ClearState();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-resourcebarrier
    [PreserveSig]
    void ResourceBarrier(uint NumBarriers, [In][MarshalUsing(CountElementName = nameof(NumBarriers))] D3D12_RESOURCE_BARRIER[] pBarriers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-discardresource
    [PreserveSig]
    void DiscardResource(ID3D12Resource pResource, nint /* optional D3D12_DISCARD_REGION* */ pRegion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-beginquery
    [PreserveSig]
    void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-endquery
    [PreserveSig]
    void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-resolvequerydata
    [PreserveSig]
    void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-setpredication
    [PreserveSig]
    void SetPredication(ID3D12Resource? pBuffer, ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-setmarker
    [PreserveSig]
    void SetMarker(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-beginevent
    [PreserveSig]
    void BeginEvent(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-endevent
    [PreserveSig]
    void EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-decodeframe
    [PreserveSig]
    void DecodeFrame(ID3D12VideoDecoder pDecoder, in D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS pOutputArguments, in D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS pInputArguments);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist-writebufferimmediate
    [PreserveSig]
    void WriteBufferImmediate(uint Count, [In][MarshalUsing(CountElementName = nameof(Count))] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER[] pParams, nint /* optional D3D12_WRITEBUFFERIMMEDIATE_MODE* */ pModes);
}
