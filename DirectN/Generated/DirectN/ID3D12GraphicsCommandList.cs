#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist
[GeneratedComInterface, Guid("5b160d0f-ac1b-4185-8ba8-b3ae42a5a455")]
public partial interface ID3D12GraphicsCommandList : ID3D12CommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CommandAllocator>))] ID3D12CommandAllocator pAllocator, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12PipelineState?>))] ID3D12PipelineState? pInitialState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearstate
    [PreserveSig]
    void ClearState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12PipelineState?>))] ID3D12PipelineState? pPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-drawinstanced
    [PreserveSig]
    void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-drawindexedinstanced
    [PreserveSig]
    void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-dispatch
    [PreserveSig]
    void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copybufferregion
    [PreserveSig]
    void CopyBufferRegion([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDstBuffer, ulong DstOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copytextureregion
    [PreserveSig]
    void CopyTextureRegion(in D3D12_TEXTURE_COPY_LOCATION pDst, uint DstX, uint DstY, uint DstZ, in D3D12_TEXTURE_COPY_LOCATION pSrc, nint /* optional D3D12_BOX* */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copyresource
    [PreserveSig]
    void CopyResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDstResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pSrcResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-copytiles
    [PreserveSig]
    void CopyTiles([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pTiledResource, in D3D12_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, in D3D12_TILE_REGION_SIZE pTileRegionSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-resolvesubresource
    [PreserveSig]
    void ResolveSubresource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDstResource, uint DstSubresource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-iasetprimitivetopology
    [PreserveSig]
    void IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-rssetviewports
    [PreserveSig]
    void RSSetViewports(uint NumViewports, [In][MarshalUsing(CountElementName = nameof(NumViewports))] D3D12_VIEWPORT[] pViewports);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-rssetscissorrects
    [PreserveSig]
    void RSSetScissorRects(uint NumRects, [In][MarshalUsing(CountElementName = nameof(NumRects))] RECT[] pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-omsetblendfactor
    [PreserveSig]
    void OMSetBlendFactor(nint /* optional float* */ BlendFactor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-omsetstencilref
    [PreserveSig]
    void OMSetStencilRef(uint StencilRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setpipelinestate
    [PreserveSig]
    void SetPipelineState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12PipelineState>))] ID3D12PipelineState pPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-resourcebarrier
    [PreserveSig]
    void ResourceBarrier(uint NumBarriers, [In][MarshalUsing(CountElementName = nameof(NumBarriers))] D3D12_RESOURCE_BARRIER[] pBarriers);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-executebundle
    [PreserveSig]
    void ExecuteBundle([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12GraphicsCommandList>))] ID3D12GraphicsCommandList pCommandList);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setdescriptorheaps
    [PreserveSig]
    void SetDescriptorHeaps(uint NumDescriptorHeaps, [In][MarshalUsing(CountElementName = nameof(NumDescriptorHeaps))] ID3D12DescriptorHeap[] ppDescriptorHeaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootsignature
    [PreserveSig]
    void SetComputeRootSignature([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12RootSignature?>))] ID3D12RootSignature? pRootSignature);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootsignature
    [PreserveSig]
    void SetGraphicsRootSignature([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12RootSignature?>))] ID3D12RootSignature? pRootSignature);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootdescriptortable
    [PreserveSig]
    void SetComputeRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootdescriptortable
    [PreserveSig]
    void SetGraphicsRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputeroot32bitconstant
    [PreserveSig]
    void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsroot32bitconstant
    [PreserveSig]
    void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputeroot32bitconstants
    [PreserveSig]
    void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, nint pSrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsroot32bitconstants
    [PreserveSig]
    void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, nint pSrcData, uint DestOffsetIn32BitValues);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootconstantbufferview
    [PreserveSig]
    void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootconstantbufferview
    [PreserveSig]
    void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootshaderresourceview
    [PreserveSig]
    void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootshaderresourceview
    [PreserveSig]
    void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setcomputerootunorderedaccessview
    [PreserveSig]
    void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setgraphicsrootunorderedaccessview
    [PreserveSig]
    void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-iasetindexbuffer
    [PreserveSig]
    void IASetIndexBuffer(nint /* optional D3D12_INDEX_BUFFER_VIEW* */ pView);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-iasetvertexbuffers
    [PreserveSig]
    void IASetVertexBuffers(uint StartSlot, uint NumViews, nint /* optional D3D12_VERTEX_BUFFER_VIEW* */ pViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-sosettargets
    [PreserveSig]
    void SOSetTargets(uint StartSlot, uint NumViews, nint /* optional D3D12_STREAM_OUTPUT_BUFFER_VIEW* */ pViews);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-omsetrendertargets
    [PreserveSig]
    void OMSetRenderTargets(uint NumRenderTargetDescriptors, nint /* optional D3D12_CPU_DESCRIPTOR_HANDLE* */ pRenderTargetDescriptors, BOOL RTsSingleHandleToDescriptorRange, nint /* optional D3D12_CPU_DESCRIPTOR_HANDLE* */ pDepthStencilDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-cleardepthstencilview
    [PreserveSig]
    void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, float Depth, byte Stencil, uint NumRects, [In][MarshalUsing(CountElementName = nameof(NumRects))] RECT[] pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearrendertargetview
    [PreserveSig]
    void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [In][MarshalUsing(ConstantElementCount = 4)] float[] ColorRGBA, uint NumRects, nint /* optional RECT* */ pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearunorderedaccessviewuint
    [PreserveSig]
    void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResource, [In][MarshalUsing(ConstantElementCount = 4)] uint[] Values, uint NumRects, [In][MarshalUsing(CountElementName = nameof(NumRects))] RECT[] pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-clearunorderedaccessviewfloat
    [PreserveSig]
    void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResource, [In][MarshalUsing(ConstantElementCount = 4)] float[] Values, uint NumRects, [In][MarshalUsing(CountElementName = nameof(NumRects))] RECT[] pRects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-discardresource
    [PreserveSig]
    void DiscardResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResource, nint /* optional D3D12_DISCARD_REGION* */ pRegion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-beginquery
    [PreserveSig]
    void BeginQuery([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12QueryHeap>))] ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-endquery
    [PreserveSig]
    void EndQuery([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12QueryHeap>))] ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-resolvequerydata
    [PreserveSig]
    void ResolveQueryData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12QueryHeap>))] ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setpredication
    [PreserveSig]
    void SetPredication([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pBuffer, ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-setmarker
    [PreserveSig]
    void SetMarker(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-beginevent
    [PreserveSig]
    void BeginEvent(uint Metadata, nint /* optional void* */ pData, uint Size);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-endevent
    [PreserveSig]
    void EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist-executeindirect
    [PreserveSig]
    void ExecuteIndirect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CommandSignature>))] ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource?>))] ID3D12Resource? pCountBuffer, ulong CountBufferOffset);
}
