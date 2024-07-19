namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class ID3D11DeviceContextExtensions
{
    public delegate void MapAction<T>(ref D3D11_MAPPED_SUBRESOURCE mapped, ref T structure);
    public delegate void MapAction(ref D3D11_MAPPED_SUBRESOURCE mapped);

    public static void WithMap(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, MapAction action, D3D11_MAP_FLAG mapFlag = 0)
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

    public static void WithMapCopyTo(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, nint source, nint size, D3D11_MAP_FLAG mapFlag = 0)
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

    public static void WithMapCopyTo(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, nint source, long size, D3D11_MAP_FLAG mapFlag = 0)
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

    public static void WithMapCopyTo(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, nint source, int size, D3D11_MAP_FLAG mapFlag = 0)
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

    public static void WithMapCopyFrom(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, nint destination, nint size, D3D11_MAP_FLAG mapFlag = 0)
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

    public static void WithMapCopyFrom(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, nint destination, long size, D3D11_MAP_FLAG mapFlag = 0)
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

    public static void WithMapCopyFrom(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, nint destination, int size, D3D11_MAP_FLAG mapFlag = 0)
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

    public static D3D11_MAPPED_SUBRESOURCE Map(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0) => Map(context?.Object!, resource?.Object!, subResource, mapType, mapFlag);
    public static D3D11_MAPPED_SUBRESOURCE Map(this ID3D11DeviceContext context, ID3D11Resource resource, uint subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(resource);
        unsafe
        {
            var mapped = new D3D11_MAPPED_SUBRESOURCE();
            context.Map(resource, subResource, mapType, (uint)mapFlag, (nint)(&mapped)).ThrowOnError();
            return mapped;
        }
    }

    public static void Unmap(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, uint subResource) => Unmap(context?.Object!, resource?.Object!, subResource);
    public static void Unmap(this ID3D11DeviceContext context, ID3D11Resource resource, uint subResource)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(resource);
        context.Unmap(resource, subResource);
    }

    public static void RSSetState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RasterizerState> state) => RSSetState(context?.Object!, state?.Object!);
    public static void RSSetState(this ID3D11DeviceContext context, ID3D11RasterizerState state)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(state);
        context.RSSetState(state);
    }

    public static void RSSetViewport(this IComObject<ID3D11DeviceContext> context, D3D11_VIEWPORT viewPort) => RSSetViewports(context?.Object!, [viewPort]);
    public static void RSSetViewports(this IComObject<ID3D11DeviceContext> context, D3D11_VIEWPORT[] viewPorts) => RSSetViewports(context?.Object!, viewPorts);
    public static void RSSetViewports(this ID3D11DeviceContext context, D3D11_VIEWPORT[] viewPorts)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(viewPorts);
        if (viewPorts.Length == 0)
            throw new ArgumentException(null, nameof(viewPorts));

        context.RSSetViewports(viewPorts.Length(), viewPorts.AsPointer());
    }

    public static void RSSetScissorRect(this IComObject<ID3D11DeviceContext> context, RECT rect) => RSSetScissorRects(context?.Object!, [rect]);
    public static void RSSetScissorRects(this IComObject<ID3D11DeviceContext> context, RECT[] rects) => RSSetScissorRects(context?.Object!, rects);
    public static void RSSetScissorRects(this ID3D11DeviceContext context, RECT[] rects)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(rects);
        if (rects.Length == 0)
            throw new ArgumentException(null, nameof(rects));

        context.RSSetScissorRects(rects.Length(), rects.AsPointer());
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

    public static void IASetVertexBuffer(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11Buffer> vertexBuffer, uint stride, uint offset = 0) => IASetVertexBuffers(context, startSlot, [vertexBuffer], [stride], [offset]);
    public static void IASetVertexBuffers(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11Buffer>[] vertexBuffers, uint[] strides, uint[]? offsets = null)
    {
        ArgumentNullException.ThrowIfNull(vertexBuffers);
        offsets ??= new uint[vertexBuffers.Length];
        IASetVertexBuffers(context?.Object!, startSlot, vertexBuffers.UnwrapAsArray()!, strides, offsets);
    }

    public static void IASetVertexBuffers(this ID3D11DeviceContext context, uint startSlot, ID3D11Buffer[] vertexBuffers, uint[] strides, uint[] offsets)
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

        ComObject.WithComInstancesOfType(vertexBuffers, ptr =>
        {
            context.IASetVertexBuffers(startSlot, vertexBuffers.Length(), ptr, strides.AsPointer(), offsets.AsPointer());
        });
    }

    public static void IASetIndexBuffer(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Buffer> indexBuffer, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_R32_UINT, int offset = 0) => IASetIndexBuffer(context?.Object!, indexBuffer?.Object!, format, offset);
    public static void IASetIndexBuffer(this ID3D11DeviceContext context, ID3D11Buffer indexBuffer, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_R32_UINT, int offset = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.IASetIndexBuffer(indexBuffer, format, (uint)offset);
    }

    public static void VSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11VertexShader> vertexShader, IComObject<ID3D11ClassInstance>[]? classInstances = null) => VSSetShader(context?.Object!, vertexShader?.Object!, classInstances.UnwrapAsArray());
    public static void VSSetShader(this ID3D11DeviceContext context, ID3D11VertexShader vertexShader, ID3D11ClassInstance?[]? classInstances = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(classInstances, ptr =>
        {
            context.VSSetShader(vertexShader, ptr, classInstances.Length());
        });
    }

    public static void GSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11GeometryShader> geometryShader, IComObject<ID3D11ClassInstance>[]? classInstances = null) => GSSetShader(context?.Object!, geometryShader?.Object!, classInstances.UnwrapAsArray());
    public static void GSSetShader(this ID3D11DeviceContext context, ID3D11GeometryShader geometryShader, ID3D11ClassInstance?[]? classInstances = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(classInstances, ptr =>
        {
            context.GSSetShader(geometryShader, ptr, classInstances.Length());
        });
    }

    public static void PSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11PixelShader>? pixelShader, IComObject<ID3D11ClassInstance>[]? classInstances = null) => PSSetShader(context?.Object!, pixelShader?.Object!, classInstances.UnwrapAsArray());
    public static void PSSetShader(this ID3D11DeviceContext context, ID3D11PixelShader? pixelShader, ID3D11ClassInstance?[]? classInstances = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(classInstances, ptr =>
        {
            context.PSSetShader(pixelShader, ptr, classInstances.Length());
        });
    }

    public static void DrawInstanced(this IComObject<ID3D11DeviceContext> context, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation) => DrawInstanced(context?.Object!, vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
    public static void DrawInstanced(this ID3D11DeviceContext context, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.DrawInstanced(vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
    }

    public static void VSSetConstantBuffer(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11Buffer> constantBuffer) => VSSetConstantBuffers(context, startSlot, [constantBuffer]);
    public static void VSSetConstantBuffers(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11Buffer>[]? constantBuffers) => VSSetConstantBuffers(context?.Object!, startSlot, constantBuffers.UnwrapAsArray());
    public static void VSSetConstantBuffers(this ID3D11DeviceContext context, uint startSlot, ID3D11Buffer?[]? constantBuffers)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(constantBuffers, ptr =>
        {
            context.VSSetConstantBuffers(startSlot, constantBuffers.Length(), ptr);
        });
    }

    public static void VSSetShaderResource(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11ShaderResourceView> shaderResourceView) => VSSetShaderResources(context, startSlot, [shaderResourceView]);
    public static void VSSetShaderResources(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11ShaderResourceView>[]? shaderResourceViews) => VSSetShaderResources(context?.Object!, startSlot, shaderResourceViews.UnwrapAsArray());
    public static void VSSetShaderResources(this ID3D11DeviceContext context, uint startSlot, ID3D11ShaderResourceView?[]? shaderResourceViews)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(shaderResourceViews, ptr =>
        {
            context.VSSetShaderResources(startSlot, shaderResourceViews.Length(), ptr);
        });
    }

    public static void GSSetShaderResource(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11ShaderResourceView> shaderResourceView) => GSSetShaderResources(context, startSlot, [shaderResourceView]);
    public static void GSSetShaderResources(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11ShaderResourceView>[]? shaderResourceViews) => GSSetShaderResources(context?.Object!, startSlot, shaderResourceViews.UnwrapAsArray());
    public static void GSSetShaderResources(this ID3D11DeviceContext context, uint startSlot, ID3D11ShaderResourceView?[]? shaderResourceViews)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(shaderResourceViews, ptr =>
        {
            context.GSSetShaderResources(startSlot, shaderResourceViews.Length(), ptr);
        });
    }

    public static void PSSetSampler(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11SamplerState> samplerState) => PSSetSamplers(context, startSlot, [samplerState]);
    public static void PSSetSamplers(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11SamplerState>[]? samplerStates) => PSSetSamplers(context?.Object!, startSlot, samplerStates.UnwrapAsArray());
    public static void PSSetSamplers(this ID3D11DeviceContext context, uint startSlot, ID3D11SamplerState?[]? samplerStates)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(samplerStates, ptr =>
        {
            context.PSSetSamplers(startSlot, samplerStates.Length(), ptr);
        });
    }

    public static void PSSetShaderResource(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11ShaderResourceView> shaderResourceView) => PSSetShaderResources(context, startSlot, [shaderResourceView]);
    public static void PSSetShaderResources(this IComObject<ID3D11DeviceContext> context, uint startSlot, IComObject<ID3D11ShaderResourceView>?[]? shaderResourceViews) => PSSetShaderResources(context?.Object!, startSlot, shaderResourceViews.UnwrapAsArray());
    public static void PSSetShaderResources(this ID3D11DeviceContext context, uint startSlot, ID3D11ShaderResourceView?[]? shaderResourceViews)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(shaderResourceViews, ptr =>
        {
            context.PSSetShaderResources(startSlot, shaderResourceViews.Length(), ptr);
        });
    }

    public static void OMSetRenderTarget(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView>? renderTargetView, IComObject<ID3D11DepthStencilView>? depthStencilView = null) => OMSetRenderTargets(context, [renderTargetView], depthStencilView);
    public static void OMSetRenderTargets(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView>?[]? renderTargetViews, IComObject<ID3D11DepthStencilView>? depthStencilView = null) => OMSetRenderTargets(context?.Object!, renderTargetViews.UnwrapAsArray(), depthStencilView?.Object!);
    public static void OMSetRenderTargets(this ID3D11DeviceContext context, ID3D11RenderTargetView?[]? renderTargetViews, ID3D11DepthStencilView? depthStencilView = null)
    {
        ArgumentNullException.ThrowIfNull(context);
        ComObject.WithComInstancesOfType(renderTargetViews, ptr =>
        {
            context.OMSetRenderTargets(renderTargetViews.Length(), ptr, depthStencilView);
        });
    }

    public static void OMSetDepthStencilState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11DepthStencilState> depthStencilState, int stencilfRef = 0) => OMSetDepthStencilState(context?.Object!, depthStencilState?.Object!, stencilfRef);
    public static void OMSetDepthStencilState(this ID3D11DeviceContext context, ID3D11DepthStencilState depthStencilState, int stencilfRef = 0)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.OMSetDepthStencilState(depthStencilState, (uint)stencilfRef);
    }

    public static void OMSetBlendState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11BlendState> blendState, float[]? blendFactor = null, uint sampleMask = 0xffffffff) => OMSetBlendState(context?.Object!, blendState?.Object!, blendFactor, sampleMask);
    public static void OMSetBlendState(this ID3D11DeviceContext context, ID3D11BlendState blendState, float[]? blendFactor = null, uint sampleMask = 0xffffffff)
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

    public static void ClearState(this IComObject<ID3D11DeviceContext> context) => ClearState(context?.Object!);
    public static void ClearState(this ID3D11DeviceContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.ClearState();
    }

    public static void Flush(this IComObject<ID3D11DeviceContext> context) => Flush(context?.Object!);
    public static void Flush(this ID3D11DeviceContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        context.Flush();
    }
}
