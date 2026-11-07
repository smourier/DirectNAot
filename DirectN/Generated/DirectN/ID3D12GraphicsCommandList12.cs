#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9524ea5e-c1b0-4fe5-a203-a75abc5d8e3a")]
public partial interface ID3D12GraphicsCommandList12 : ID3D12GraphicsCommandList11
{
    [PreserveSig]
    void CopyBufferRegions(uint NumRegions, [In][MarshalUsing(CountElementName = nameof(NumRegions))] ID3D12Resource[] ppDestBuffers, [In][MarshalUsing(CountElementName = nameof(NumRegions))] ulong[] pDestOffsets, [In][MarshalUsing(CountElementName = nameof(NumRegions))] ID3D12Resource[] ppSourceBuffers, [In][MarshalUsing(CountElementName = nameof(NumRegions))] ulong[] pSourceOffsets, [In][MarshalUsing(CountElementName = nameof(NumRegions))] ulong[] pSizes);
    
    [PreserveSig]
    void CopyTextureRegions(uint NumCopyDescs, [In][MarshalUsing(CountElementName = nameof(NumCopyDescs))] D3D12_TEXTURE_COPY_DESC[] pCopyDescs);
    
    [PreserveSig]
    void CopyResources(uint NumSourceDestPairs, [In][MarshalUsing(CountElementName = nameof(NumSourceDestPairs))] ID3D12Resource[] ppDestResources, [In][MarshalUsing(CountElementName = nameof(NumSourceDestPairs))] ID3D12Resource[] ppSourceResources);
    
    [PreserveSig]
    void CopyTilesAsync([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pTiledResource, in D3D12_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, in D3D12_TILE_REGION_SIZE pTileRegionSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pBuffer, ulong BufferOffset, D3D12_TILE_COPY_FLAGS Flags);
    
    [PreserveSig]
    void ResolveSubresourceRegionAsync([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDestResource, uint DestSubresource, uint DestX, uint DestY, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pSourceResource, uint SourceSubresource, in RECT pSourceRect, DXGI_FORMAT Format, D3D12_RESOLVE_MODE ResolveMode);
    
    [PreserveSig]
    void ResolveQueryDataAsync([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12QueryHeap>))] ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDestBuffer, ulong DestOffset);
    
    [PreserveSig]
    void ClearBoundDepthStencilView(D3D12_CLEAR_FLAGS ClearFlags, float Depth, byte Stencil, uint NumRegions, nint /* optional D3D12_BOX* */ pRegions);
    
    [PreserveSig]
    void ClearBoundRenderTargetViews(uint RenderTargetMask, [In][MarshalUsing(ConstantElementCount = 8)] D3D12_CLEAR_DATA[] pClearValues, nint /* optional uint* */ pNumRegions, nint /* optional D3D12_BOX** */ ppRegions);
    
    [PreserveSig]
    void ClearTextureSubresources(uint NumClearDescs, [In][MarshalUsing(CountElementName = nameof(NumClearDescs))] D3D12_CLEAR_TEXTURE_DESC[] pClearDescs);
    
    [PreserveSig]
    void FillBuffers(uint NumFillDescs, [In][MarshalUsing(CountElementName = nameof(NumFillDescs))] D3D12_FILL_BUFFER_DESC[] pFillDescs);
}
