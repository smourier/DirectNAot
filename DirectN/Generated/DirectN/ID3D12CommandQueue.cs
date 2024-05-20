#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12commandqueue
[GeneratedComInterface, Guid("0ec870a6-5d7e-4c22-8cfc-5baae07616ed")]
public partial interface ID3D12CommandQueue : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-updatetilemappings
    [PreserveSig]
    void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, nint /* optional D3D12_TILED_RESOURCE_COORDINATE* */ pResourceRegionStartCoordinates, nint /* optional D3D12_TILE_REGION_SIZE* */ pResourceRegionSizes, ID3D12Heap? pHeap, uint NumRanges, nint /* optional D3D12_TILE_RANGE_FLAGS* */ pRangeFlags, nint /* optional uint* */ pHeapRangeStartOffsets, nint /* optional uint* */ pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-copytilemappings
    [PreserveSig]
    void CopyTileMappings(ID3D12Resource pDstResource, in D3D12_TILED_RESOURCE_COORDINATE pDstRegionStartCoordinate, ID3D12Resource pSrcResource, in D3D12_TILED_RESOURCE_COORDINATE pSrcRegionStartCoordinate, in D3D12_TILE_REGION_SIZE pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-executecommandlists
    [PreserveSig]
    void ExecuteCommandLists(uint NumCommandLists, [In][MarshalUsing(CountElementName = nameof(NumCommandLists))] ID3D12CommandList[] ppCommandLists);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-setmarker
    [PreserveSig]
    void SetMarker(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-beginevent
    [PreserveSig]
    void BeginEvent(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-endevent
    [PreserveSig]
    void EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-signal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Signal(ID3D12Fence pFence, ulong Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-wait
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Wait(ID3D12Fence pFence, ulong Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-gettimestampfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimestampFrequency(out ulong pFrequency);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-getclockcalibration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClockCalibration(out ulong pGpuTimestamp, out ulong pCpuTimestamp);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-getdesc
    [PreserveSig]
    D3D12_COMMAND_QUEUE_DESC GetDesc();
}
