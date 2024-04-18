namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist
[GeneratedComInterface, Guid("5b160d0f-ac1b-4185-8ba8-b3ae42a5a455")]
public partial interface ID3D12GraphicsCommandList : ID3D12CommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Reset(ID3D12CommandAllocator pAllocator, ID3D12PipelineState pInitialState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearstate
    [PreserveSig]
    public void ClearState(ID3D12PipelineState pPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-drawinstanced
    [PreserveSig]
    public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-drawindexedinstanced
    [PreserveSig]
    public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-dispatch
    [PreserveSig]
    public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copybufferregion
    [PreserveSig]
    public void CopyBufferRegion(ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copytextureregion
    [PreserveSig]
    public void CopyTextureRegion(in D3D12_TEXTURE_COPY_LOCATION pDst, uint DstX, uint DstY, uint DstZ, in D3D12_TEXTURE_COPY_LOCATION pSrc, nint/* nint */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copyresource
    [PreserveSig]
    public void CopyResource(ID3D12Resource pDstResource, ID3D12Resource pSrcResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copytiles
    [PreserveSig]
    public void CopyTiles(ID3D12Resource pTiledResource, in D3D12_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, in D3D12_TILE_REGION_SIZE pTileRegionSize, ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-resolvesubresource
    [PreserveSig]
    public void ResolveSubresource(ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-iasetprimitivetopology
    [PreserveSig]
    public void IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-rssetviewports
    [PreserveSig]
    public void RSSetViewports(uint NumViewports, in D3D12_VIEWPORT pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-rssetscissorrects
    [PreserveSig]
    public void RSSetScissorRects(uint NumRects, FoundationRECT pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-omsetblendfactor
    [PreserveSig]
    public void OMSetBlendFactor(nint/* nint */ BlendFactor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-omsetstencilref
    [PreserveSig]
    public void OMSetStencilRef(uint StencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setpipelinestate
    [PreserveSig]
    public void SetPipelineState(ID3D12PipelineState pPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-resourcebarrier
    [PreserveSig]
    public void ResourceBarrier(uint NumBarriers, in D3D12_RESOURCE_BARRIER pBarriers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-executebundle
    [PreserveSig]
    public void ExecuteBundle(ID3D12GraphicsCommandList pCommandList);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setdescriptorheaps
    [PreserveSig]
    public void SetDescriptorHeaps(uint NumDescriptorHeaps, in ID3D12DescriptorHeap ppDescriptorHeaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootsignature
    [PreserveSig]
    public void SetComputeRootSignature(ID3D12RootSignature pRootSignature);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootsignature
    [PreserveSig]
    public void SetGraphicsRootSignature(ID3D12RootSignature pRootSignature);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootdescriptortable
    [PreserveSig]
    public void SetComputeRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootdescriptortable
    [PreserveSig]
    public void SetGraphicsRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputeroot32bitconstant
    [PreserveSig]
    public void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsroot32bitconstant
    [PreserveSig]
    public void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputeroot32bitconstants
    [PreserveSig]
    public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, nint pSrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsroot32bitconstants
    [PreserveSig]
    public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, nint pSrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootconstantbufferview
    [PreserveSig]
    public void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootconstantbufferview
    [PreserveSig]
    public void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootshaderresourceview
    [PreserveSig]
    public void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootshaderresourceview
    [PreserveSig]
    public void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootunorderedaccessview
    [PreserveSig]
    public void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootunorderedaccessview
    [PreserveSig]
    public void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-iasetindexbuffer
    [PreserveSig]
    public void IASetIndexBuffer(nint/* nint */ pView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-iasetvertexbuffers
    [PreserveSig]
    public void IASetVertexBuffers(uint StartSlot, uint NumViews, nint/* nint */ pViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-sosettargets
    [PreserveSig]
    public void SOSetTargets(uint StartSlot, uint NumViews, nint/* nint */ pViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-omsetrendertargets
    [PreserveSig]
    public void OMSetRenderTargets(uint NumRenderTargetDescriptors, nint/* nint */ pRenderTargetDescriptors, [MarshalAs(UnmanagedType.U4)] bool RTsSingleHandleToDescriptorRange, nint/* nint */ pDepthStencilDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-cleardepthstencilview
    [PreserveSig]
    public void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, float Depth, byte Stencil, uint NumRects, FoundationRECT pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearrendertargetview
    [PreserveSig]
    public void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, in float ColorRGBA, uint NumRects, nint/* nint */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearunorderedaccessviewuint
    [PreserveSig]
    public void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource pResource, in uint Values, uint NumRects, FoundationRECT pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearunorderedaccessviewfloat
    [PreserveSig]
    public void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource pResource, in float Values, uint NumRects, FoundationRECT pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-discardresource
    [PreserveSig]
    public void DiscardResource(ID3D12Resource pResource, nint/* nint */ pRegion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-beginquery
    [PreserveSig]
    public void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-endquery
    [PreserveSig]
    public void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-resolvequerydata
    [PreserveSig]
    public void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setpredication
    [PreserveSig]
    public void SetPredication(ID3D12Resource pBuffer, ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setmarker
    [PreserveSig]
    public void SetMarker(uint Metadata, nint/* nint */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-beginevent
    [PreserveSig]
    public void BeginEvent(uint Metadata, nint/* nint */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-endevent
    [PreserveSig]
    public void EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-executeindirect
    [PreserveSig]
    public void ExecuteIndirect(ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource pCountBuffer, ulong CountBufferOffset);
}
