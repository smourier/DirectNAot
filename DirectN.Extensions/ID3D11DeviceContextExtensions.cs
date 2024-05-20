﻿namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class ID3D11DeviceContextExtensions
{
    public delegate void MapAction<T>(ref D3D11_MAPPED_SUBRESOURCE mapped, ref T structure);
    public delegate void MapAction(ref D3D11_MAPPED_SUBRESOURCE mapped);

    public static void WithMap<T>(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, MapAction<T> action, D3D11_MAP_FLAG mapFlag = 0)
    {
        ArgumentNullException.ThrowIfNull(action);
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            var structure = Marshal.PtrToStructure<T>(map.pData);
            action(ref map, ref structure);
            Marshal.StructureToPtr(structure, map.pData, false);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMap(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, MapAction action, D3D11_MAP_FLAG mapFlag = 0)
    {
        ArgumentNullException.ThrowIfNull(action);
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            action(ref map);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMapCopyTo(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, object structure, D3D11_MAP_FLAG mapFlag = 0)
    {
        ArgumentNullException.ThrowIfNull(structure);
        using var mem = new ComMemory(structure);
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            mem.Pointer.CopyTo(map.pData, mem.Size);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMapCopyTo(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, IntPtr source, IntPtr size, D3D11_MAP_FLAG mapFlag = 0)
    {
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            source.CopyTo(map.pData, size);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMapCopyTo(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, IntPtr source, long size, D3D11_MAP_FLAG mapFlag = 0)
    {
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            source.CopyTo(map.pData, size);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMapCopyTo(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, IntPtr source, int size, D3D11_MAP_FLAG mapFlag = 0)
    {
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            source.CopyTo(map.pData, size);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMapCopyFrom(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, IntPtr destination, IntPtr size, D3D11_MAP_FLAG mapFlag = 0)
    {
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            map.pData.CopyTo(destination, size);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMapCopyFrom(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, IntPtr destination, long size, D3D11_MAP_FLAG mapFlag = 0)
    {
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            map.pData.CopyTo(destination, size);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static void WithMapCopyFrom(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, IntPtr destination, int size, D3D11_MAP_FLAG mapFlag = 0)
    {
        var map = Map(context, resource, subResource, mapType, mapFlag);
        try
        {
            map.pData.CopyTo(destination, size);
        }
        finally
        {
            Unmap(context, resource, subResource);
        }
    }

    public static D3D11_MAPPED_SUBRESOURCE Map(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0) => Map(context?.Object!, resource?.Object!, subResource, mapType, mapFlag);
    public static D3D11_MAPPED_SUBRESOURCE Map(this ID3D11DeviceContext context, ID3D11Resource resource, int subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(resource);
        using var ptr = new ComMemory(Marshal.SizeOf<D3D11_MAPPED_SUBRESOURCE>());
        context.Map(resource, (uint)subResource, mapType, (uint)mapFlag, ptr.Pointer).ThrowOnError();
        return ptr.ToStructure<D3D11_MAPPED_SUBRESOURCE>();
    }

    public static void Unmap(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource) => Unmap(context?.Object!, resource?.Object!, subResource);
    public static void Unmap(this ID3D11DeviceContext context, ID3D11Resource resource, int subResource)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(resource);
        context.Unmap(resource, (uint)subResource);
    }

    public static void RSSetState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RasterizerState> state) => RSSetState(context?.Object!, state?.Object!);
    public static void RSSetState(this ID3D11DeviceContext context, ID3D11RasterizerState state)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(state);
        context.RSSetState(state);
    }

    public static void RSSetViewport(this IComObject<ID3D11DeviceContext> context, D3D11_VIEWPORT viewPort)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        context.Object.RSSetViewports(1, new[] { viewPort });
    }

    public static void RSSetViewports(this IComObject<ID3D11DeviceContext> context, D3D11_VIEWPORT[] viewPorts) => RSSetViewports(context?.Object!, viewPorts);
    public static void RSSetViewports(this ID3D11DeviceContext context, D3D11_VIEWPORT[] viewPorts)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(viewPorts);
        if (viewPorts.Length == 0)
            throw new ArgumentException(null, nameof(viewPorts));

        context.RSSetViewports(viewPorts.Length, viewPorts);
    }

    public static void RSSetScissorRect(this IComObject<ID3D11DeviceContext> context, RECT rect)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        context.Object.RSSetScissorRects(1, new[] { rect });
    }

    public static void RSSetScissorRects(this IComObject<ID3D11DeviceContext> context, RECT[] rects) => RSSetScissorRects(context?.Object!, rects);
    public static void RSSetScissorRects(this ID3D11DeviceContext context, RECT[] rects)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(rects);
        if (rects.Length == 0)
            throw new ArgumentException(null, nameof(rects));

        context.RSSetScissorRects(rects.Length, rects);
    }

    public static void ClearRenderTargetView(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView> renderTargetView, D3DCOLORVALUE color) => ClearRenderTargetView(context?.Object!, renderTargetView?.Object!, color.ToArray());
    public static void ClearRenderTargetView(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView> renderTargetView, float[] colorRGBA) => ClearRenderTargetView(context?.Object!, renderTargetView?.Object!, colorRGBA);
    public static void ClearRenderTargetView(this ID3D11DeviceContext context, ID3D11RenderTargetView renderTargetView, float[] colorRGBA)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(renderTargetView);
        ArgumentNullException.ThrowIfNull(colorRGBA);
        if (colorRGBA.Length != 4)
            throw new ArgumentException(null, nameof(colorRGBA));

        context.ClearRenderTargetView(renderTargetView, colorRGBA);
    }

    public static void ClearDepthStencilView(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11DepthStencilView> depthStencilView, D3D11_CLEAR_FLAG flags, float depth, byte stencil) => ClearDepthStencilView(context?.Object!, depthStencilView?.Object!, flags, depth, stencil);
    public static void ClearDepthStencilView(this ID3D11DeviceContext context, ID3D11DepthStencilView depthStencilView, D3D11_CLEAR_FLAG flags, float depth, byte stencil)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(depthStencilView);
        context.ClearDepthStencilView(depthStencilView, (uint)flags, depth, stencil);
    }

    public static void IASetPrimitiveTopology(this IComObject<ID3D11DeviceContext> context, D3D_PRIMITIVE_TOPOLOGY topology) => IASetPrimitiveTopology(context?.Object!, topology);
    public static void IASetPrimitiveTopology(this ID3D11DeviceContext context, D3D_PRIMITIVE_TOPOLOGY topology)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.IASetPrimitiveTopology(topology);
    }

    public static void IASetInputLayout(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11InputLayout> inputLayout) => IASetInputLayout(context?.Object!, inputLayout?.Object!);
    public static void IASetInputLayout(this ID3D11DeviceContext context, ID3D11InputLayout inputLayout)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.IASetInputLayout(inputLayout);
    }

    public static void IASetVertexBuffer(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer> vertexBuffer, int stride, int offset = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        ArgumentNullException.ThrowIfNull(vertexBuffer);
        if (vertexBuffer.Object == null)
            throw new ArgumentException(null, nameof(vertexBuffer));

        context.Object.IASetVertexBuffers((uint)startSlot, 1, new[] { vertexBuffer.Object }, new[] { (uint)stride }, new[] { (uint)offset });
    }

    public static void IASetVertexBuffers(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer>[] vertexBuffers, int[] strides, int[] offsets = null)
    {
        ArgumentNullException.ThrowIfNull(vertexBuffers);
        if (offsets == null)
        {
            offsets = new int[vertexBuffers.Length];
        }

        IASetVertexBuffers(context?.Object!, startSlot, vertexBuffers.ToArray(), strides, offsets);
    }

    public static void IASetVertexBuffers(this ID3D11DeviceContext context, int startSlot, ID3D11Buffer[] vertexBuffers, int[] strides, int[] offsets)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(vertexBuffers);
        ArgumentNullException.ThrowIfNull(strides);
        ArgumentNullException.ThrowIfNull(offsets);
        if (vertexBuffers.Length == 0)
            throw new ArgumentException(null, nameof(vertexBuffers));

        if (vertexBuffers.Length != strides.Length)
            throw new ArgumentException(null, nameof(strides));

        if (vertexBuffers.Length != offsets.Length)
            throw new ArgumentException(null, nameof(offsets));

        context.IASetVertexBuffers((uint)startSlot, vertexBuffers.Length, vertexBuffers, strides.Select(s => (uint)s).ToArray(), offsets.Select(s => (uint)s).ToArray());
    }

    public static void IASetIndexBuffer(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Buffer> indexBuffer, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_R32_UINT, int offset = 0) => IASetIndexBuffer(context?.Object!, indexBuffer?.Object!, format, offset);
    public static void IASetIndexBuffer(this ID3D11DeviceContext context, ID3D11Buffer indexBuffer, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_R32_UINT, int offset = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.IASetIndexBuffer(indexBuffer, format, (uint)offset);
    }

    public static void VSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11VertexShader> vertexShader, IComObject<ID3D11ClassInstance>[] classInstances = null) => VSSetShader(context?.Object!, vertexShader?.Object!, classInstances.ToArray());
    public static void VSSetShader(this ID3D11DeviceContext context, ID3D11VertexShader vertexShader, ID3D11ClassInstance[] classInstances = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.VSSetShader(vertexShader, classInstances, (classInstances?.Length).GetValueOrDefault());
    }

    public static void GSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11GeometryShader> geometryShader, IComObject<ID3D11ClassInstance>[] classInstances = null) => GSSetShader(context?.Object!, geometryShader?.Object!, classInstances.ToArray());
    public static void GSSetShader(this ID3D11DeviceContext context, ID3D11GeometryShader geometryShader, ID3D11ClassInstance[] classInstances = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GSSetShader(geometryShader, classInstances, (classInstances?.Length).GetValueOrDefault());
    }

    public static void PSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11PixelShader> pixelShader, IComObject<ID3D11ClassInstance>[] classInstances = null) => PSSetShader(context?.Object!, pixelShader?.Object!, classInstances.ToArray());
    public static void PSSetShader(this ID3D11DeviceContext context, ID3D11PixelShader pixelShader, ID3D11ClassInstance[] classInstances = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.PSSetShader(pixelShader, classInstances, (classInstances?.Length).GetValueOrDefault());
    }

    public static void DrawInstanced(this IComObject<ID3D11DeviceContext> context, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation) => DrawInstanced(context?.Object!, vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
    public static void DrawInstanced(this ID3D11DeviceContext context, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.DrawInstanced(vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
    }

    public static void VSSetConstantBuffer(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer> constantBuffer)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        ArgumentNullException.ThrowIfNull(constantBuffer);
        if (constantBuffer.Object == null)
            throw new ArgumentException(null, nameof(constantBuffer));

        context.Object.VSSetConstantBuffers((uint)startSlot, 1, new[] { constantBuffer.Object });
    }

    public static void VSSetConstantBuffers(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer>[] constantBuffers) => VSSetConstantBuffers(context?.Object!, startSlot, constantBuffers.ToArray());
    public static void VSSetConstantBuffers(this ID3D11DeviceContext context, int startSlot, ID3D11Buffer[] constantBuffers)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.VSSetConstantBuffers((uint)startSlot, (constantBuffers?.Length).GetValueOrDefault(), constantBuffers);
    }

    public static void VSSetShaderResources(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11ShaderResourceView>[] shaderResourceViews) => VSSetShaderResources(context?.Object!, startSlot, shaderResourceViews.ToArray());
    public static void VSSetShaderResources(this ID3D11DeviceContext context, int startSlot, ID3D11ShaderResourceView[] shaderResourceViews)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.VSSetShaderResources((uint)startSlot, (shaderResourceViews?.Length).GetValueOrDefault(), shaderResourceViews);
    }

    public static void GSSetShaderResource(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11ShaderResourceView> shaderResourceView)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        ArgumentNullException.ThrowIfNull(shaderResourceView);
        if (shaderResourceView.Object == null)
            throw new ArgumentException(null, nameof(shaderResourceView));

        context.Object.GSSetShaderResources((uint)startSlot, 1, new[] { shaderResourceView.Object });
    }

    public static void GSSetShaderResources(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11ShaderResourceView>[] shaderResourceViews) => GSSetShaderResources(context?.Object!, startSlot, shaderResourceViews.ToArray());
    public static void GSSetShaderResources(this ID3D11DeviceContext context, int startSlot, ID3D11ShaderResourceView[] shaderResourceViews)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.GSSetShaderResources((uint)startSlot, (shaderResourceViews?.Length).GetValueOrDefault(), shaderResourceViews);
    }

    public static void PSSetSampler(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11SamplerState> samplerState)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        ArgumentNullException.ThrowIfNull(samplerState);
        if (samplerState.Object == null)
            throw new ArgumentException(null, nameof(samplerState));

        context.Object.PSSetSamplers((uint)startSlot, 1, new[] { samplerState.Object });
    }

    public static void PSSetSamplers(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11SamplerState>[] samplerStates) => PSSetSamplers(context?.Object!, startSlot, samplerStates.ToArray());
    public static void PSSetSamplers(this ID3D11DeviceContext context, int startSlot, ID3D11SamplerState[] samplerStates)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.PSSetSamplers((uint)startSlot, (samplerStates?.Length).GetValueOrDefault(), samplerStates);
    }

    public static void PSSetShaderResource(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11ShaderResourceView> shaderResourceView)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        ArgumentNullException.ThrowIfNull(shaderResourceView);
        if (shaderResourceView.Object == null)
            throw new ArgumentException(null, nameof(shaderResourceView));

        context.Object.PSSetShaderResources((uint)startSlot, 1, new[] { shaderResourceView.Object });
    }

    public static void PSSetShaderResources(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11ShaderResourceView>[] shaderResourceViews) => PSSetShaderResources(context?.Object!, startSlot, shaderResourceViews.ToArray());
    public static void PSSetShaderResources(this ID3D11DeviceContext context, int startSlot, ID3D11ShaderResourceView[] shaderResourceViews)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.PSSetShaderResources((uint)startSlot, (shaderResourceViews?.Length).GetValueOrDefault(), shaderResourceViews);
    }

    public static void OMSetRenderTarget(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView> renderTargetView, IComObject<ID3D11DepthStencilView> depthStencilView = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        if (context.Object == null)
            throw new ArgumentException(null, nameof(context));

        ArgumentNullException.ThrowIfNull(renderTargetView);
        if (renderTargetView.Object == null)
            throw new ArgumentException(null, nameof(renderTargetView));

        context.Object.OMSetRenderTargets(1, new[] { renderTargetView.Object }, depthStencilView?.Object!);
    }

    public static void OMSetRenderTargets(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView>[] renderTargetViews, IComObject<ID3D11DepthStencilView> depthStencilView = null) => OMSetRenderTargets(context?.Object!, renderTargetViews.ToArray(), depthStencilView?.Object!);
    public static void OMSetRenderTargets(this ID3D11DeviceContext context, ID3D11RenderTargetView[] renderTargetViews, ID3D11DepthStencilView depthStencilView = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.OMSetRenderTargets((renderTargetViews?.Length).GetValueOrDefault(), renderTargetViews, depthStencilView);
    }

    public static void OMSetDepthStencilState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11DepthStencilState> depthStencilState, int stencilfRef = 0) => OMSetDepthStencilState(context?.Object!, depthStencilState?.Object!, stencilfRef);
    public static void OMSetDepthStencilState(this ID3D11DeviceContext context, ID3D11DepthStencilState depthStencilState, int stencilfRef = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.OMSetDepthStencilState(depthStencilState, (uint)stencilfRef);
    }

    public static void OMSetBlendState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11BlendState> blendState, float[] blendFactor = null, uint sampleMask = 0xffffffff) => OMSetBlendState(context?.Object!, blendState?.Object!, blendFactor, sampleMask);
    public static void OMSetBlendState(this ID3D11DeviceContext context, ID3D11BlendState blendState, float[] blendFactor = null, uint sampleMask = 0xffffffff)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.OMSetBlendState(blendState, blendFactor, sampleMask);
    }

    public static void DrawIndexed(this IComObject<ID3D11DeviceContext> context, int indexCount, int startIndexLocation, int baseVertexLocation) => DrawIndexed(context?.Object!, indexCount, startIndexLocation, baseVertexLocation);
    public static void DrawIndexed(this ID3D11DeviceContext context, int indexCount, int startIndexLocation, int baseVertexLocation)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.DrawIndexed((uint)indexCount, (uint)startIndexLocation, baseVertexLocation);
    }
}
