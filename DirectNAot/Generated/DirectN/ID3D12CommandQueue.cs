namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12commandqueue
[GeneratedComInterface, Guid("0ec870a6-5d7e-4c22-8cfc-5baae07616ed")]
public partial interface ID3D12CommandQueue : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-updatetilemappings
    [PreserveSig]
    public void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, nint/* nint */ pResourceRegionStartCoordinates, nint/* nint */ pResourceRegionSizes, ID3D12Heap pHeap, uint NumRanges, nint/* nint */ pRangeFlags, nint/* nint */ pHeapRangeStartOffsets, nint/* nint */ pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-copytilemappings
    [PreserveSig]
    public void CopyTileMappings(ID3D12Resource pDstResource, in D3D12_TILED_RESOURCE_COORDINATE pDstRegionStartCoordinate, ID3D12Resource pSrcResource, in D3D12_TILED_RESOURCE_COORDINATE pSrcRegionStartCoordinate, in D3D12_TILE_REGION_SIZE pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-executecommandlists
    [PreserveSig]
    public void ExecuteCommandLists(uint NumCommandLists, in ID3D12CommandList ppCommandLists);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-setmarker
    [PreserveSig]
    public void SetMarker(uint Metadata, nint/* nint */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-beginevent
    [PreserveSig]
    public void BeginEvent(uint Metadata, nint/* nint */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-endevent
    [PreserveSig]
    public void EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-signal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Signal(ID3D12Fence pFence, ulong Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-wait
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Wait(ID3D12Fence pFence, ulong Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-gettimestampfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTimestampFrequency(out ulong pFrequency);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-getclockcalibration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetClockCalibration(out ulong pGpuTimestamp, out ulong pCpuTimestamp);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandqueue-getdesc
    [PreserveSig]
    public D3D12_COMMAND_QUEUE_DESC GetDesc();
}
