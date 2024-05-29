﻿using DirectN.Extensions.Com;
using DirectN.Extensions.Utilities;

namespace DirectN.Samples.MinimalD3D11
{
    // this code is ported from https://gist.github.com/d7samurai/261c69490cce0620d0bfc93003cd1052
    public class SampleWindow(string title) : D3DSwapChainWindow(title)
    {
        private readonly unsafe uint _sizeOfConstants = (uint)sizeof(Constants);

        private IComObject<ID3D11RenderTargetView>? _framebufferRTV;
        private IComObject<ID3D11DepthStencilView>? _framebufferDSV;
        private IComObject<ID3D11DepthStencilView>? _shadowmapDSV;
        private IComObject<ID3D11ShaderResourceView>? _shadowmapSRV;
        private IComObject<ID3D11Buffer>? _constantBuffer;
        private IComObject<ID3D11Buffer>? _vertexBuffer;
        private IComObject<ID3D11ShaderResourceView>? _vertexBufferSRV;
        private IComObject<ID3D11DepthStencilState>? _depthStencilState;
        private IComObject<ID3D11RasterizerState>? _cullBackRS;
        private IComObject<ID3D11RasterizerState>? _cullFrontRS;
        private IComObject<ID3D11VertexShader>? _framebufferVS;
        private IComObject<ID3D11PixelShader>? _framebufferPS;
        private IComObject<ID3D11VertexShader>? _shadowmapVS;
        private Constants _constants;
        private D3D11_VIEWPORT _shadowmapVP;
        private D3D11_VIEWPORT _framebufferVP;
        private readonly float[] _framebufferClear = [0.025f, 0.025f, 0.025f, 1];

        protected override void CreateDeviceDependentResources(IComObject<ID3D11Device> device, IComObject<IDXGISwapChain1> swapChain)
        {
            ArgumentNullException.ThrowIfNull(device);
            ArgumentNullException.ThrowIfNull(swapChain);
            using var framebufferTexture = swapChain.GetBuffer<ID3D11Texture2D>(0);
            if (framebufferTexture == null)
                return;

            var framebufferDesc = new D3D11_RENDER_TARGET_VIEW_DESC
            {
                Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM_SRGB,
                ViewDimension = D3D11_RTV_DIMENSION.D3D11_RTV_DIMENSION_TEXTURE2D
            };

            _framebufferRTV = device.CreateRenderTargetView(framebufferTexture, framebufferDesc);

            var framebufferDepthDesc = framebufferTexture.GetDesc();
            framebufferDepthDesc.Format = DXGI_FORMAT.DXGI_FORMAT_D24_UNORM_S8_UINT;
            framebufferDepthDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_DEPTH_STENCIL;

            using var framebufferDepthTexture = device.CreateTexture2D(framebufferDepthDesc);
            _framebufferDSV = device.CreateDepthStencilView(framebufferDepthTexture);

            var shadowmapDepthDesc = new D3D11_TEXTURE2D_DESC
            {
                Width = 2048,
                Height = 2048,
                MipLevels = 1,
                ArraySize = 1,
                Format = DXGI_FORMAT.DXGI_FORMAT_R32_TYPELESS
            };
            shadowmapDepthDesc.SampleDesc.Count = 1;
            shadowmapDepthDesc.Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT;
            shadowmapDepthDesc.BindFlags = (uint)(D3D11_BIND_FLAG.D3D11_BIND_DEPTH_STENCIL | D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE);

            using var shadowmapDepthTexture = device.CreateTexture2D(shadowmapDepthDesc);
            var shadowmapDSVdesc = new D3D11_DEPTH_STENCIL_VIEW_DESC
            {
                Format = DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT,
                ViewDimension = D3D11_DSV_DIMENSION.D3D11_DSV_DIMENSION_TEXTURE2D
            };

            _shadowmapDSV = device.CreateDepthStencilView(shadowmapDepthTexture, shadowmapDSVdesc);

            var shadowmapSRVdesc = new D3D11_SHADER_RESOURCE_VIEW_DESC
            {
                Format = DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT,
                ViewDimension = D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2D
            };

            var t2D = new D3D11_TEX2D_SRV
            {
                MipLevels = 1
            };
            shadowmapSRVdesc.Anonymous.Texture2D = t2D;

            _shadowmapSRV = device.CreateShaderResourceView(shadowmapDepthTexture, shadowmapSRVdesc);

            var constantBufferDesc = new D3D11_BUFFER_DESC
            {
                ByteWidth = _sizeOfConstants,
                Usage = D3D11_USAGE.D3D11_USAGE_DYNAMIC,
                BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_CONSTANT_BUFFER,
                CPUAccessFlags = (uint)D3D11_CPU_ACCESS_FLAG.D3D11_CPU_ACCESS_WRITE
            };

            _constantBuffer = device.CreateBuffer(constantBufferDesc);

            var vertexData = new float[] { -1, 1, -1, 0, 0, 1, 1, -1, 9.5f, 0, -0.58f, 0.58f, -1, 2, 2, 0.58f, 0.58f, -1, 7.5f, 2, -0.58f, 0.58f, -1, 0, 0, 0.58f, 0.58f, -1, 0, 0, -0.58f, 0.58f, -0.58f, 0, 0, 0.58f, 0.58f, -0.58f, 0, 0 };

            var vertexBufferDesc = new D3D11_BUFFER_DESC
            {
                ByteWidth = (uint)(sizeof(float) * vertexData.Length),
                Usage = D3D11_USAGE.D3D11_USAGE_IMMUTABLE,
                BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE,
                MiscFlags = (uint)D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_BUFFER_STRUCTURED,
                StructureByteStride = 5 * sizeof(float)
            };

            var vData = new D3D11_SUBRESOURCE_DATA
            {
                pSysMem = vertexData.AsPointer()
            };
            _vertexBuffer = device.CreateBuffer(vertexBufferDesc, vData);

            var vertexBufferSRVdesc = new D3D11_SHADER_RESOURCE_VIEW_DESC
            {
                Format = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN,
                ViewDimension = D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFER
            };

            var bf = new D3D11_BUFFER_SRV();
            bf.Anonymous2.NumElements = vertexBufferDesc.ByteWidth / vertexBufferDesc.StructureByteStride;
            vertexBufferSRVdesc.Anonymous.Buffer = bf;

            _vertexBufferSRV = device.CreateShaderResourceView(_vertexBuffer, vertexBufferSRVdesc);

            var depthStencilDesc = new D3D11_DEPTH_STENCIL_DESC
            {
                DepthEnable = true,
                DepthWriteMask = D3D11_DEPTH_WRITE_MASK.D3D11_DEPTH_WRITE_MASK_ALL,
                DepthFunc = D3D11_COMPARISON_FUNC.D3D11_COMPARISON_LESS
            };

            _depthStencilState = device.CreateDepthStencilState(depthStencilDesc);

            var rasterizerDesc = new D3D11_RASTERIZER_DESC
            {
                FillMode = D3D11_FILL_MODE.D3D11_FILL_SOLID,
                CullMode = D3D11_CULL_MODE.D3D11_CULL_BACK
            };

            _cullBackRS = device.CreateRasterizerState(rasterizerDesc);

            rasterizerDesc.CullMode = D3D11_CULL_MODE.D3D11_CULL_FRONT;
            _cullFrontRS = device.CreateRasterizerState(rasterizerDesc);

            var shaderBytes = Assembly.GetExecutingAssembly().LoadFromResource(GetType().Namespace + ".shaders.hlsl");
            using var framebufferVSBlob = D3D11Functions.D3DCompile(shaderBytes, "framebuffer_vs", "vs_5_0");
            _framebufferVS = device.CreateVertexShader(framebufferVSBlob);

            using var framebufferPSBlob = D3D11Functions.D3DCompile(shaderBytes, "framebuffer_ps", "ps_5_0");
            _framebufferPS = device.CreatePixelShader(framebufferPSBlob);

            using var shadowmapVSBlob = D3D11Functions.D3DCompile(shaderBytes, "shadowmap_vs", "vs_5_0");
            _shadowmapVS = device.CreateVertexShader(shadowmapVSBlob);

            _framebufferVP = new D3D11_VIEWPORT
            {
                Width = framebufferDepthDesc.Width,
                Height = framebufferDepthDesc.Height,
                MaxDepth = 1
            };

            _shadowmapVP = new D3D11_VIEWPORT
            {
                Width = shadowmapDepthDesc.Width,
                Height = shadowmapDepthDesc.Height,
                MaxDepth = 1
            };

            _constants = new Constants
            {
                LightRotation = new D2D_VECTOR_4F(0.8f, 0.6f, 0.0f, 0),
                ModelRotation = new D2D_VECTOR_4F(0.0f, 0.0f, 0.0f, 0),
                ModelTranslation = new D2D_VECTOR_4F(0.0f, 0.0f, 4.0f, 0),
                ShadowmapSize = new D2D_VECTOR_4F(_shadowmapVP.Width, _shadowmapVP.Height, 0, 0)
            };

            Extensions.Utilities.Extensions.CopyFromWithPad(
                _constants.CameraProjection,
                new float[] { 2.0f / (_framebufferVP.Width / _framebufferVP.Height), 0, 0, 0, 0, 2, 0, 0, 0, 0, 1.125f, 1, 0, 0, -1.125f, 0 },
                InlineArraySingle_16.Length);

            Extensions.Utilities.Extensions.CopyFromWithPad(
                _constants.LightProjection,
                new float[] { 0.5f, 0, 0, 0, 0, 0.5f, 0, 0, 0, 0, 0.125f, 0, 0, 0, -0.125f, 1 },
                InlineArraySingle_16.Length);
        }

        protected override void DisposeDeviceDependentResources()
        {
            Interlocked.Exchange(ref _framebufferRTV, null)?.Dispose();
            Interlocked.Exchange(ref _framebufferDSV, null)?.Dispose();
            Interlocked.Exchange(ref _shadowmapDSV, null)?.Dispose();
            Interlocked.Exchange(ref _shadowmapSRV, null)?.Dispose();
            Interlocked.Exchange(ref _constantBuffer, null)?.Dispose();
            Interlocked.Exchange(ref _vertexBuffer, null)?.Dispose();
            Interlocked.Exchange(ref _vertexBufferSRV, null)?.Dispose();
            Interlocked.Exchange(ref _depthStencilState, null)?.Dispose();
            Interlocked.Exchange(ref _cullBackRS, null)?.Dispose();
            Interlocked.Exchange(ref _cullFrontRS, null)?.Dispose();
            Interlocked.Exchange(ref _framebufferVS, null)?.Dispose();
            Interlocked.Exchange(ref _framebufferPS, null)?.Dispose();
            Interlocked.Exchange(ref _shadowmapVS, null)?.Dispose();
            base.DisposeDeviceDependentResources();
        }

        protected override void Render(IComObject<ID3D11DeviceContext> deviceContext, IComObject<IDXGISwapChain1> swapChain)
        {
            ArgumentNullException.ThrowIfNull(deviceContext);
            ArgumentNullException.ThrowIfNull(swapChain);
            var shadowmapDSV = _shadowmapDSV;
            var shadowmapVS = _shadowmapVS;
            var shadowmapSRV = _shadowmapSRV;
            var constantBuffer = _constantBuffer;
            var vertexBufferSRV = _vertexBufferSRV;
            var depthStencilState = _depthStencilState;
            var cullFrontRS = _cullFrontRS;
            var cullBackRS = _cullBackRS;
            var framebufferRTV = _framebufferRTV;
            var framebufferDSV = _framebufferDSV;
            var framebufferVS = _framebufferVS;
            var framebufferPS = _framebufferPS;
            if (shadowmapDSV == null || shadowmapVS == null || shadowmapSRV == null ||
                constantBuffer == null || vertexBufferSRV == null || depthStencilState == null ||
                cullFrontRS == null || cullBackRS == null || framebufferRTV == null ||
                framebufferDSV == null || framebufferVS == null || framebufferPS == null)
                return;

            _constants.ModelRotation.x += 0.001f;
            _constants.ModelRotation.y += 0.005f;
            _constants.ModelRotation.z += 0.003f;

            unsafe
            {
                deviceContext.WithMapCopyTo(constantBuffer, 0, D3D11_MAP.D3D11_MAP_WRITE_DISCARD, (nint)Unsafe.AsPointer(ref _constants), _sizeOfConstants);
            }

            deviceContext.ClearDepthStencilView(shadowmapDSV, D3D11_CLEAR_FLAG.D3D11_CLEAR_DEPTH, 1.0f, 0);

            deviceContext.OMSetRenderTargets(null, shadowmapDSV);
            deviceContext.OMSetDepthStencilState(depthStencilState);

            deviceContext.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP);

            deviceContext.VSSetConstantBuffers(0, [constantBuffer]);
            deviceContext.VSSetShaderResources(0, [vertexBufferSRV]);
            deviceContext.VSSetShader(shadowmapVS);

            deviceContext.RSSetViewports([_shadowmapVP]);
            deviceContext.RSSetState(cullFrontRS);

            deviceContext.PSSetShader(null);

            deviceContext.DrawInstanced(8, 24, 0, 0);

            deviceContext.ClearRenderTargetView(framebufferRTV, _framebufferClear);
            deviceContext.ClearDepthStencilView(framebufferDSV, D3D11_CLEAR_FLAG.D3D11_CLEAR_DEPTH, 1.0f, 0);

            deviceContext.OMSetRenderTargets([framebufferRTV], _framebufferDSV);

            deviceContext.VSSetShader(framebufferVS);

            deviceContext.RSSetViewports([_framebufferVP]);
            deviceContext.RSSetState(cullBackRS);

            deviceContext.PSSetShaderResources(1, [shadowmapSRV]);
            deviceContext.PSSetShader(framebufferPS);

            deviceContext.DrawInstanced(8, 24, 0, 0);

            deviceContext.PSSetShaderResources(1, [null]);

            swapChain.Present(1, 0);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Constants
        {
            public InlineArraySingle_16 CameraProjection;
            public InlineArraySingle_16 LightProjection;
            public D2D_VECTOR_4F LightRotation; // D2D_VECTOR_4F is equivalent to XMFLOAT4
            public D2D_VECTOR_4F ModelRotation;
            public D2D_VECTOR_4F ModelTranslation;
            public D2D_VECTOR_4F ShadowmapSize;
        };
    }
}