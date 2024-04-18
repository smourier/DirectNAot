namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/nn-d3d11_2-id3d11devicecontext2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("420d5b32-b90c-4da4-bef0-359f6a24a83a")]
public partial interface ID3D11DeviceContext2 : ID3D11DeviceContext1
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-updatetilemappings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateTileMappings(ID3D11Resource pTiledResource, uint NumTiledResourceRegions, nint/* nint */ pTiledResourceRegionStartCoordinates, nint/* nint */ pTiledResourceRegionSizes, ID3D11Buffer pTilePool, uint NumRanges, nint/* nint */ pRangeFlags, nint/* nint */ pTilePoolStartOffsets, nint/* nint */ pRangeTileCounts, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-copytilemappings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CopyTileMappings(ID3D11Resource pDestTiledResource, in D3D11_TILED_RESOURCE_COORDINATE pDestRegionStartCoordinate, ID3D11Resource pSourceTiledResource, in D3D11_TILED_RESOURCE_COORDINATE pSourceRegionStartCoordinate, in D3D11_TILE_REGION_SIZE pTileRegionSize, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-copytiles
    [PreserveSig]
    public void CopyTiles(ID3D11Resource pTiledResource, in D3D11_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, in D3D11_TILE_REGION_SIZE pTileRegionSize, ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-updatetiles
    [PreserveSig]
    public void UpdateTiles(ID3D11Resource pDestTiledResource, in D3D11_TILED_RESOURCE_COORDINATE pDestTileRegionStartCoordinate, in D3D11_TILE_REGION_SIZE pDestTileRegionSize, nint pSourceTileData, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-resizetilepool
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ResizeTilePool(ID3D11Buffer pTilePool, ulong NewSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-tiledresourcebarrier
    [PreserveSig]
    public void TiledResourceBarrier(ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-isannotationenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsAnnotationEnabled();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-setmarkerint
    [PreserveSig]
    public void SetMarkerInt(PWSTR pLabel, int Data);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-begineventint
    [PreserveSig]
    public void BeginEventInt(PWSTR pLabel, int Data);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_2/nf-d3d11_2-id3d11devicecontext2-endevent
    [PreserveSig]
    public void EndEvent();
}
