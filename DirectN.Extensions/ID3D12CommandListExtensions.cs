namespace DirectN.Extensions;

public static class ID3D12CommandListExtensions
{
    public static void GetType(this IComObject<ID3D12CommandList> list) => GetType(list?.Object!);
    public static D3D12_COMMAND_LIST_TYPE GetType(this ID3D12CommandList list)
    {
        ArgumentNullException.ThrowIfNull(list);
        return list.GetType();
    }

    public static void Close(this IComObject<ID3D12GraphicsCommandList> list) => Close(list?.Object!);
    public static void Close(this ID3D12GraphicsCommandList list)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.Close().ThrowOnError();
    }

    public static void Reset(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12CommandAllocator> allocator, IComObject<ID3D12PipelineState>? initialState = null) => Reset(list?.Object!, allocator?.Object!, initialState?.Object!);
    public static void Reset(this ID3D12GraphicsCommandList list, ID3D12CommandAllocator allocator, ID3D12PipelineState? initialState = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(allocator);
        list.Reset(allocator, initialState).ThrowOnError();
    }

    public static void ClearState(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12PipelineState>? pipelineState = null) => ClearState(list?.Object!, pipelineState?.Object!);
    public static void ClearState(this ID3D12GraphicsCommandList list, ID3D12PipelineState? pipelineState = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.ClearState(pipelineState);
    }

    public static void DrawInstanced(this IComObject<ID3D12GraphicsCommandList> list, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation) => DrawInstanced(list?.Object!, vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
    public static void DrawInstanced(this ID3D12GraphicsCommandList list, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.DrawInstanced(vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
    }

    public static void DrawIndexedInstanced(this IComObject<ID3D12GraphicsCommandList> list, uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexLocation, uint startInstanceLocation) => DrawIndexedInstanced(list?.Object!, indexCountPerInstance, instanceCount, startIndexLocation, baseVertexLocation, startInstanceLocation);
    public static void DrawIndexedInstanced(this ID3D12GraphicsCommandList list, uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexLocation, uint startInstanceLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.DrawIndexedInstanced(indexCountPerInstance, instanceCount, startIndexLocation, baseVertexLocation, startInstanceLocation);
    }

    public static void Dispatch(this IComObject<ID3D12GraphicsCommandList> list, uint threadGroupCountX, uint threadGroupCountY, uint threadGroupCountZ) => Dispatch(list?.Object!, threadGroupCountX, threadGroupCountY, threadGroupCountZ);
    public static void Dispatch(this ID3D12GraphicsCommandList list, uint threadGroupCountX, uint threadGroupCountY, uint threadGroupCountZ)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.Dispatch(threadGroupCountX, threadGroupCountY, threadGroupCountZ);
    }

    public static void CopyBufferRegion(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> dstBuffer, ulong dstOffset, IComObject<ID3D12Resource> srcBuffer, ulong srcOffset, ulong numBytes) => CopyBufferRegion(list?.Object!, dstBuffer?.Object!, dstOffset, srcBuffer?.Object!, srcOffset, numBytes);
    public static void CopyBufferRegion(this ID3D12GraphicsCommandList list, ID3D12Resource dstBuffer, ulong dstOffset, ID3D12Resource srcBuffer, ulong srcOffset, ulong numBytes)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.CopyBufferRegion(dstBuffer, dstOffset, srcBuffer, srcOffset, numBytes);
    }

    public static void CopyTextureRegion(this IComObject<ID3D12GraphicsCommandList> list, D3D12_TEXTURE_COPY_LOCATION dst, uint dstX, uint dstY, uint dstZ, D3D12_TEXTURE_COPY_LOCATION src, D3D12_BOX? srcBox = null) => CopyTextureRegion(list?.Object!, dst, dstX, dstY, dstZ, src, srcBox);
    public static void CopyTextureRegion(this ID3D12GraphicsCommandList list, D3D12_TEXTURE_COPY_LOCATION dst, uint dstX, uint dstY, uint dstZ, D3D12_TEXTURE_COPY_LOCATION src, D3D12_BOX? srcBox = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.CopyTextureRegion(dst, dstX, dstY, dstZ, src, srcBox.CopyToPointer());
    }

    public static void CopyResource(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> dstResource, IComObject<ID3D12Resource> srcResource) => CopyResource(list?.Object!, dstResource?.Object!, srcResource?.Object!);
    public static void CopyResource(this ID3D12GraphicsCommandList list, ID3D12Resource dstResource, ID3D12Resource srcResource)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.CopyResource(dstResource, srcResource);
    }

    public static void CopyTiles(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> tiledResource, D3D12_TILED_RESOURCE_COORDINATE tileRegionStartCoordinate, D3D12_TILE_REGION_SIZE tileRegionSize, IComObject<ID3D12Resource> buffer, ulong bufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS flags) => CopyTiles(list?.Object!, tiledResource?.Object!, tileRegionStartCoordinate, tileRegionSize, buffer?.Object!, bufferStartOffsetInBytes, flags);
    public static void CopyTiles(this ID3D12GraphicsCommandList list, ID3D12Resource tiledResource, D3D12_TILED_RESOURCE_COORDINATE tileRegionStartCoordinate, D3D12_TILE_REGION_SIZE tileRegionSize, ID3D12Resource buffer, ulong bufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS flags)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.CopyTiles(tiledResource, tileRegionStartCoordinate, tileRegionSize, buffer, bufferStartOffsetInBytes, flags);
    }

    public static void ResolveSubresource(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> dstResource, uint dstSubresource, IComObject<ID3D12Resource> srcResource, uint srcSubresource, DXGI_FORMAT format) => ResolveSubresource(list?.Object!, dstResource?.Object!, dstSubresource, srcResource?.Object!, srcSubresource, format);
    public static void ResolveSubresource(this ID3D12GraphicsCommandList list, ID3D12Resource dstResource, uint dstSubresource, ID3D12Resource srcResource, uint srcSubresource, DXGI_FORMAT format)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.ResolveSubresource(dstResource, dstSubresource, srcResource, srcSubresource, format);
    }

    public static void IASetPrimitiveTopology(this IComObject<ID3D12GraphicsCommandList> list, D3D_PRIMITIVE_TOPOLOGY primitiveTopology) => IASetPrimitiveTopology(list?.Object!, primitiveTopology);
    public static void IASetPrimitiveTopology(this ID3D12GraphicsCommandList list, D3D_PRIMITIVE_TOPOLOGY primitiveTopology)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.IASetPrimitiveTopology(primitiveTopology);
    }

    public static void RSSetViewports(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<D3D12_VIEWPORT> viewports) => RSSetViewports(list?.Object!, viewports);
    public static void RSSetViewports(this ID3D12GraphicsCommandList list, IEnumerable<D3D12_VIEWPORT> viewports)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(viewports);
        var array = viewports.ToArray();
        list.RSSetViewports((uint)array.Length, array);
    }

    public static void RSSetScissorRects(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<RECT> rects) => RSSetScissorRects(list?.Object!, rects);
    public static void RSSetScissorRects(this ID3D12GraphicsCommandList list, IEnumerable<RECT> rects)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(rects);
        var array = rects.ToArray();
        list.RSSetScissorRects((uint)array.Length, array);
    }

    public static void OMSetBlendFactor(this IComObject<ID3D12GraphicsCommandList> list, IReadOnlyList<float> blendFactor) => OMSetBlendFactor(list?.Object!, blendFactor);
    public static void OMSetBlendFactor(this ID3D12GraphicsCommandList list, IReadOnlyList<float> blendFactor)
    {
        ArgumentNullException.ThrowIfNull(list);
        if (blendFactor == null || blendFactor.Count != 4)
            throw new ArgumentNullException(nameof(blendFactor));

        list.OMSetBlendFactor(blendFactor);
    }

    public static void OMSetStencilRef(this IComObject<ID3D12GraphicsCommandList> list, uint stencilRef) => OMSetStencilRef(list?.Object!, stencilRef);
    public static void OMSetStencilRef(this ID3D12GraphicsCommandList list, uint stencilRef)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.OMSetStencilRef(stencilRef);
    }

    public static void SetPipelineState(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12PipelineState> pipelineState) => SetPipelineState(list?.Object!, pipelineState?.Object!);
    public static void SetPipelineState(this ID3D12GraphicsCommandList list, ID3D12PipelineState pipelineState)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(pipelineState);
        list.SetPipelineState(pipelineState);
    }

    public static void ResourceBarrier(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<D3D12_RESOURCE_BARRIER> barriers) => ResourceBarrier(list?.Object!, barriers);
    public static void ResourceBarrier(this ID3D12GraphicsCommandList list, IEnumerable<D3D12_RESOURCE_BARRIER> barriers)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(barriers);
        var array = barriers.ToArray();
        list.ResourceBarrier((uint)array.Length, array);
    }

    public static void ExecuteBundle(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12GraphicsCommandList> commandLists) => ExecuteBundle(list?.Object!, commandLists?.Object!);
    public static void ExecuteBundle(this ID3D12GraphicsCommandList list, ID3D12GraphicsCommandList commandLists)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(commandLists);
        list.ExecuteBundle(commandLists);
    }

    public static void SetDescriptorHeaps(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<IComObject<ID3D12DescriptorHeap>> heaps) => SetDescriptorHeaps(list?.Object!, heaps.Unwrap()!);
    public static void SetDescriptorHeaps(this ID3D12GraphicsCommandList list, IEnumerable<ID3D12DescriptorHeap> heaps)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(heaps);
        var array = heaps.ToArray();
        list.SetDescriptorHeaps((uint)array.Length, array);
    }

    public static void SetComputeRootSignature(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12RootSignature>? rootSignature = null) => SetComputeRootSignature(list?.Object!, rootSignature?.Object!);
    public static void SetComputeRootSignature(this ID3D12GraphicsCommandList list, ID3D12RootSignature? rootSignature = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetComputeRootSignature(rootSignature);
    }

    public static void SetGraphicsRootSignature(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12RootSignature>? rootSignature = null) => SetGraphicsRootSignature(list?.Object!, rootSignature?.Object!);
    public static void SetGraphicsRootSignature(this ID3D12GraphicsCommandList list, ID3D12RootSignature? rootSignature = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetGraphicsRootSignature(rootSignature);
    }

    public static void SetComputeRootDescriptorTable(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor) => SetComputeRootDescriptorTable(list?.Object!, rootParameterIndex, baseDescriptor);
    public static void SetComputeRootDescriptorTable(this ID3D12GraphicsCommandList list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetComputeRootDescriptorTable(rootParameterIndex, baseDescriptor);
    }

    public static void SetGraphicsRootDescriptorTable(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor) => SetGraphicsRootDescriptorTable(list?.Object!, rootParameterIndex, baseDescriptor);
    public static void SetGraphicsRootDescriptorTable(this ID3D12GraphicsCommandList list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetGraphicsRootDescriptorTable(rootParameterIndex, baseDescriptor);
    }

    public static void SetComputeRoot32BitConstant(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues) => SetComputeRoot32BitConstant(list?.Object!, rootParameterIndex, srcData, destOffsetIn32BitValues);
    public static void SetComputeRoot32BitConstant(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetComputeRoot32BitConstant(rootParameterIndex, srcData, destOffsetIn32BitValues);
    }

    public static void SetGraphicsRoot32BitConstant(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues) => SetGraphicsRoot32BitConstant(list?.Object!, rootParameterIndex, srcData, destOffsetIn32BitValues);
    public static void SetGraphicsRoot32BitConstant(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetGraphicsRoot32BitConstant(rootParameterIndex, srcData, destOffsetIn32BitValues);
    }

    public static void SetComputeRoot32BitConstants(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint num32BitValuesToSet, nint srcData, uint destOffsetIn32BitValues) => SetComputeRoot32BitConstants(list?.Object!, rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
    public static void SetComputeRoot32BitConstants(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint num32BitValuesToSet, nint srcData, uint destOffsetIn32BitValues)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetComputeRoot32BitConstants(rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
    }

    public static void SetGraphicsRoot32BitConstants(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint num32BitValuesToSet, nint srcData, uint destOffsetIn32BitValues) => SetGraphicsRoot32BitConstants(list?.Object!, rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
    public static void SetGraphicsRoot32BitConstants(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint num32BitValuesToSet, nint srcData, uint destOffsetIn32BitValues)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetGraphicsRoot32BitConstants(rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
    }

    public static void SetComputeRootConstantBufferView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetComputeRootConstantBufferView(list?.Object!, rootParameterIndex, bufferLocation);
    public static void SetComputeRootConstantBufferView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetComputeRootConstantBufferView(rootParameterIndex, bufferLocation);
    }

    public static void SetGraphicsRootConstantBufferView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetGraphicsRootConstantBufferView(list?.Object!, rootParameterIndex, bufferLocation);
    public static void SetGraphicsRootConstantBufferView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetGraphicsRootConstantBufferView(rootParameterIndex, bufferLocation);
    }

    public static void SetComputeRootShaderResourceView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetComputeRootShaderResourceView(list?.Object!, rootParameterIndex, bufferLocation);
    public static void SetComputeRootShaderResourceView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetComputeRootShaderResourceView(rootParameterIndex, bufferLocation);
    }

    public static void SetGraphicsRootShaderResourceView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetGraphicsRootShaderResourceView(list?.Object!, rootParameterIndex, bufferLocation);
    public static void SetGraphicsRootShaderResourceView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetGraphicsRootShaderResourceView(rootParameterIndex, bufferLocation);
    }

    public static void SetComputeRootUnorderedAccessView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetComputeRootUnorderedAccessView(list?.Object!, rootParameterIndex, bufferLocation);
    public static void SetComputeRootUnorderedAccessView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetComputeRootUnorderedAccessView(rootParameterIndex, bufferLocation);
    }

    public static void SetGraphicsRootUnorderedAccessView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetGraphicsRootUnorderedAccessView(list?.Object!, rootParameterIndex, bufferLocation);
    public static void SetGraphicsRootUnorderedAccessView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetGraphicsRootUnorderedAccessView(rootParameterIndex, bufferLocation);
    }

    public static void IASetIndexBuffer(this IComObject<ID3D12GraphicsCommandList> list, D3D12_INDEX_BUFFER_VIEW? view = null) => IASetIndexBuffer(list?.Object!, view);
    public static void IASetIndexBuffer(this ID3D12GraphicsCommandList list, D3D12_INDEX_BUFFER_VIEW? view = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.IASetIndexBuffer(view.CopyToPointer());
    }

    public static void IASetVertexBuffers(this IComObject<ID3D12GraphicsCommandList> list, uint startSlot, IEnumerable<D3D12_VERTEX_BUFFER_VIEW> views) => IASetVertexBuffers(list?.Object!, startSlot, views);
    public static void IASetVertexBuffers(this ID3D12GraphicsCommandList list, uint startSlot, IEnumerable<D3D12_VERTEX_BUFFER_VIEW> views)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(views);
        var array = views.ToArray();
        list.IASetVertexBuffers(startSlot, array.Length(), array.AsPointer());
    }

    public static void SOSetTargets(this IComObject<ID3D12GraphicsCommandList> list, uint startSlot, IEnumerable<D3D12_STREAM_OUTPUT_BUFFER_VIEW> views) => SOSetTargets(list?.Object!, startSlot, views);
    public static void SOSetTargets(this ID3D12GraphicsCommandList list, uint startSlot, IEnumerable<D3D12_STREAM_OUTPUT_BUFFER_VIEW> views)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(views);
        var array = views.ToArray();
        list.SOSetTargets(startSlot, array.Length(), array.AsPointer());
    }

    public static void OMSetRenderTargets(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<D3D12_CPU_DESCRIPTOR_HANDLE> renderTargetDescriptors, bool rtsSingleHandleToDescriptorRange, D3D12_CPU_DESCRIPTOR_HANDLE? depthStencilDescriptor = null) => OMSetRenderTargets(list?.Object!, renderTargetDescriptors, rtsSingleHandleToDescriptorRange, depthStencilDescriptor);
    public static void OMSetRenderTargets(this ID3D12GraphicsCommandList list, IEnumerable<D3D12_CPU_DESCRIPTOR_HANDLE> renderTargetDescriptors, bool rtsSingleHandleToDescriptorRange, D3D12_CPU_DESCRIPTOR_HANDLE? depthStencilDescriptor = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        var array = renderTargetDescriptors?.ToArray();
        list.OMSetRenderTargets(array.Length(), array.AsPointer(), rtsSingleHandleToDescriptorRange, depthStencilDescriptor.CopyToPointer());
    }

    public static void ClearDepthStencilView(this IComObject<ID3D12GraphicsCommandList> list, D3D12_CPU_DESCRIPTOR_HANDLE depthStencilView, D3D12_CLEAR_FLAGS clearFlags, float depth, byte stencil, IEnumerable<RECT>? rects = null) => ClearDepthStencilView(list?.Object!, depthStencilView, clearFlags, depth, stencil, rects);
    public static void ClearDepthStencilView(this ID3D12GraphicsCommandList list, D3D12_CPU_DESCRIPTOR_HANDLE depthStencilView, D3D12_CLEAR_FLAGS clearFlags, float depth, byte stencil, IEnumerable<RECT>? rects = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        var array = rects?.ToArray();
        list.ClearDepthStencilView(depthStencilView, clearFlags, depth, stencil, array.Length(), array!);
    }

    public static void ClearRenderTargetView(this IComObject<ID3D12GraphicsCommandList> list, D3D12_CPU_DESCRIPTOR_HANDLE renderTargetView, float[] colorRGBA, IEnumerable<RECT>? rects = null) => ClearRenderTargetView(list?.Object!, renderTargetView, colorRGBA, rects);
    public static void ClearRenderTargetView(this ID3D12GraphicsCommandList list, D3D12_CPU_DESCRIPTOR_HANDLE renderTargetView, float[] colorRGBA, IEnumerable<RECT>? rects = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        var array = rects?.ToArray();
        list.ClearRenderTargetView(renderTargetView, colorRGBA, array.Length(), array.AsPointer());
    }

    public static void ClearUnorderedAccessViewUint(this IComObject<ID3D12GraphicsCommandList> list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, IComObject<ID3D12Resource> resource, uint[] values, IEnumerable<RECT>? rects = null) => ClearUnorderedAccessViewUint(list?.Object!, viewGPUHandleInCurrentHeap, viewCPUHandle, resource?.Object!, values, rects);
    public static void ClearUnorderedAccessViewUint(this ID3D12GraphicsCommandList list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, ID3D12Resource resource, uint[] values, IEnumerable<RECT>? rects = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(resource);
        var array = rects?.ToArray();
        list.ClearUnorderedAccessViewUint(viewGPUHandleInCurrentHeap, viewCPUHandle, resource, values, array.Length(), array!);
    }

    public static void ClearUnorderedAccessViewFloat(this IComObject<ID3D12GraphicsCommandList> list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, IComObject<ID3D12Resource> resource, float[] values, IEnumerable<RECT>? rects = null) => ClearUnorderedAccessViewFloat(list?.Object!, viewGPUHandleInCurrentHeap, viewCPUHandle, resource?.Object!, values, rects);
    public static void ClearUnorderedAccessViewFloat(this ID3D12GraphicsCommandList list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, ID3D12Resource resource, float[] values, IEnumerable<RECT>? rects = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(resource);
        var array = rects?.ToArray();
        list.ClearUnorderedAccessViewFloat(viewGPUHandleInCurrentHeap, viewCPUHandle, resource, values, array.Length(), array!);
    }

    public static void DiscardResource(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> resource, D3D12_DISCARD_REGION? region = null) => DiscardResource(list?.Object!, resource?.Object!, region);
    public static void DiscardResource(this ID3D12GraphicsCommandList list, ID3D12Resource resource, D3D12_DISCARD_REGION? region = null)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(resource);
        list.DiscardResource(resource, region.CopyToPointer());
    }

    public static void BeginQuery(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12QueryHeap> queryHeap, D3D12_QUERY_TYPE type, uint index) => BeginQuery(list?.Object!, queryHeap?.Object!, type, index);
    public static void BeginQuery(this ID3D12GraphicsCommandList list, ID3D12QueryHeap queryHeap, D3D12_QUERY_TYPE type, uint index)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(queryHeap);
        list.BeginQuery(queryHeap, type, index);
    }

    public static void EndQuery(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12QueryHeap> queryHeap, D3D12_QUERY_TYPE type, uint index) => EndQuery(list?.Object!, queryHeap?.Object!, type, index);
    public static void EndQuery(this ID3D12GraphicsCommandList list, ID3D12QueryHeap queryHeap, D3D12_QUERY_TYPE type, uint index)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(queryHeap);
        list.EndQuery(queryHeap, type, index);
    }

    public static void ResolveQueryData(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12QueryHeap> queryHeap, D3D12_QUERY_TYPE type, uint startIndex, uint numQueries, IComObject<ID3D12Resource> destinationBuffer, ulong alignedDestinationBufferOffset) => ResolveQueryData(list?.Object!, queryHeap?.Object!, type, startIndex, numQueries, destinationBuffer?.Object!, alignedDestinationBufferOffset);
    public static void ResolveQueryData(this ID3D12GraphicsCommandList list, ID3D12QueryHeap queryHeap, D3D12_QUERY_TYPE type, uint startIndex, uint numQueries, ID3D12Resource destinationBuffer, ulong alignedDestinationBufferOffset)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(queryHeap);
        ArgumentNullException.ThrowIfNull(destinationBuffer);
        list.ResolveQueryData(queryHeap, type, startIndex, numQueries, destinationBuffer, alignedDestinationBufferOffset);
    }

    public static void SetPredication(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> buffer, ulong alignedBufferOffset, D3D12_PREDICATION_OP operation) => SetPredication(list?.Object!, buffer?.Object!, alignedBufferOffset, operation);
    public static void SetPredication(this ID3D12GraphicsCommandList list, ID3D12Resource buffer, ulong alignedBufferOffset, D3D12_PREDICATION_OP operation)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(buffer);
        list.SetPredication(buffer, alignedBufferOffset, operation);
    }

    public static void SetMarker(this IComObject<ID3D12GraphicsCommandList> list, uint metadata, nint data, uint size) => SetMarker(list?.Object!, metadata, data, size);
    public static void SetMarker(this ID3D12GraphicsCommandList list, uint metadata, nint data, uint size)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.SetMarker(metadata, data, size);
    }

    public static void BeginEvent(this IComObject<ID3D12GraphicsCommandList> list, uint metadata, nint data, uint size) => BeginEvent(list?.Object!, metadata, data, size);
    public static void BeginEvent(this ID3D12GraphicsCommandList list, uint metadata, nint data, uint size)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.BeginEvent(metadata, data, size);
    }

    public static void EndEvent(this IComObject<ID3D12GraphicsCommandList> list) => EndEvent(list?.Object!);
    public static void EndEvent(this ID3D12GraphicsCommandList list)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.EndEvent();
    }

    public static void ExecuteIndirect(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12CommandSignature> commandSignature, uint maxCommandCount, IComObject<ID3D12Resource> argumentBuffer, ulong argumentBufferOffset, IComObject<ID3D12Resource>? countBuffer = null, ulong countBufferOffset = 0) => ExecuteIndirect(list?.Object!, commandSignature?.Object!, maxCommandCount, argumentBuffer?.Object!, argumentBufferOffset, countBuffer?.Object!, countBufferOffset);
    public static void ExecuteIndirect(this ID3D12GraphicsCommandList list, ID3D12CommandSignature commandSignature, uint maxCommandCount, ID3D12Resource argumentBuffer, ulong argumentBufferOffset, ID3D12Resource? countBuffer = null, ulong countBufferOffset = 0)
    {
        ArgumentNullException.ThrowIfNull(list);
        list.ExecuteIndirect(commandSignature, maxCommandCount, argumentBuffer, argumentBufferOffset, countBuffer, countBufferOffset);
    }
}
