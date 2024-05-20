namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class ID3D11DeviceExtensions
{
    public static IComObject<T> CreateTexture2D<T>(this IComObject<ID3D11Device> device, D3D11_TEXTURE2D_DESC desc, D3D11_SUBRESOURCE_DATA initialData) where T : ID3D11Texture2D => CreateTexture2D<T>(device?.Object!, desc, new D3D11_SUBRESOURCE_DATA[] { initialData });
    public static IComObject<T> CreateTexture2D<T>(this IComObject<ID3D11Device> device, D3D11_TEXTURE2D_DESC desc, D3D11_SUBRESOURCE_DATA[] initialData = null) where T : ID3D11Texture2D => CreateTexture2D<T>(device?.Object!, desc, initialData);
    public static IComObject<ID3D11Texture2D> CreateTexture2D(this IComObject<ID3D11Device> device, D3D11_TEXTURE2D_DESC desc, D3D11_SUBRESOURCE_DATA[] initialData = null) => CreateTexture2D<ID3D11Texture2D>(device?.Object!, desc, initialData);
    public static IComObject<T> CreateTexture2D<T>(this ID3D11Device device, D3D11_TEXTURE2D_DESC desc, D3D11_SUBRESOURCE_DATA[] initialData = null) where T : ID3D11Texture2D
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateTexture2D(ref desc, initialData, out var texture).ThrowOnError();
        return new ComObject<T>((T)texture);
    }

    public static IComObject<ID3D11Buffer> CreateBuffer(this IComObject<ID3D11Device> device, D3D11_BUFFER_DESC desc, D3D11_SUBRESOURCE_DATA? initialData = null) => CreateBuffer(device?.Object!, desc, initialData);
    public static IComObject<ID3D11Buffer> CreateBuffer(this ID3D11Device device, D3D11_BUFFER_DESC desc, D3D11_SUBRESOURCE_DATA? initialData = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        using var mem = new ComMemory(initialData);
        device.CreateBuffer(ref desc, mem.Pointer, out var buffer).ThrowOnError();
        return new ComObject<ID3D11Buffer>(buffer);
    }

    public static IComObject<ID3D11RasterizerState> CreateRasterizerState(this IComObject<ID3D11Device> device, D3D11_RASTERIZER_DESC desc) => CreateRasterizerState(device?.Object!, desc);
    public static IComObject<ID3D11RasterizerState> CreateRasterizerState(this ID3D11Device device, D3D11_RASTERIZER_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateRasterizerState(ref desc, out var state).ThrowOnError();
        return new ComObject<ID3D11RasterizerState>(state);
    }

    public static IComObject<ID3D11SamplerState> CreateSamplerState(this IComObject<ID3D11Device> device, D3D11_SAMPLER_DESC desc) => CreateSamplerState(device?.Object!, desc);
    public static IComObject<ID3D11SamplerState> CreateSamplerState(this ID3D11Device device, D3D11_SAMPLER_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateSamplerState(ref desc, out var state).ThrowOnError();
        return new ComObject<ID3D11SamplerState>(state);
    }

    public static IComObject<ID3D11BlendState> CreateBlendState(this IComObject<ID3D11Device> device, D3D11_BLEND_DESC desc) => CreateBlendState(device?.Object!, desc);
    public static IComObject<ID3D11BlendState> CreateBlendState(this ID3D11Device device, D3D11_BLEND_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);

        device.CreateBlendState(ref desc, out var state).ThrowOnError();
        return new ComObject<ID3D11BlendState>(state);
    }

    public static IComObject<ID3D11DepthStencilState> CreateDepthStencilState(this IComObject<ID3D11Device> device, D3D11_DEPTH_STENCIL_DESC desc) => CreateDepthStencilState(device?.Object!, desc);
    public static IComObject<ID3D11DepthStencilState> CreateDepthStencilState(this ID3D11Device device, D3D11_DEPTH_STENCIL_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateDepthStencilState(ref desc, out var state).ThrowOnError();
        return new ComObject<ID3D11DepthStencilState>(state);
    }

    public static IComObject<ID3D11DomainShader> CreateDomainShader(this IComObject<ID3D11Device> device, IComObject<ID3DBlob> blob, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateDomainShader(device?.Object!, blob?.Object!, classLinkage?.Object!);
    public static IComObject<ID3D11DomainShader> CreateDomainShader(this ID3D11Device device, ID3DBlob blob, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(blob);
        device.CreateDomainShader(blob.GetBufferPointer(), blob.GetBufferSize(), classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11DomainShader>(shader);
    }

    public static IComObject<ID3D11DomainShader> CreateDomainShader(this IComObject<ID3D11Device> device, IntPtr shaderBytecode, int bytecodeLength, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateDomainShader(device?.Object!, shaderBytecode, bytecodeLength, classLinkage?.Object!);
    public static IComObject<ID3D11DomainShader> CreateDomainShader(this ID3D11Device device, IntPtr shaderBytecode, int bytecodeLength, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateDomainShader(shaderBytecode, (IntPtr)bytecodeLength, classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11DomainShader>(shader);
    }

    public static IComObject<ID3D11ComputeShader> CreateComputeShader(this IComObject<ID3D11Device> device, IComObject<ID3DBlob> blob, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateComputeShader(device?.Object!, blob?.Object!, classLinkage?.Object!);
    public static IComObject<ID3D11ComputeShader> CreateComputeShader(this ID3D11Device device, ID3DBlob blob, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(blob);
        device.CreateComputeShader(blob.GetBufferPointer(), blob.GetBufferSize(), classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11ComputeShader>(shader);
    }

    public static IComObject<ID3D11ComputeShader> CreateComputeShader(this IComObject<ID3D11Device> device, IntPtr shaderBytecode, int bytecodeLength, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateComputeShader(device?.Object!, shaderBytecode, bytecodeLength, classLinkage?.Object!);
    public static IComObject<ID3D11ComputeShader> CreateComputeShader(this ID3D11Device device, IntPtr shaderBytecode, int bytecodeLength, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateComputeShader(shaderBytecode, (IntPtr)bytecodeLength, classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11ComputeShader>(shader);
    }

    public static IComObject<ID3D11HullShader> CreateHullShader(this IComObject<ID3D11Device> device, IComObject<ID3DBlob> blob, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateHullShader(device?.Object!, blob?.Object!, classLinkage?.Object!);
    public static IComObject<ID3D11HullShader> CreateHullShader(this ID3D11Device device, ID3DBlob blob, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(blob);
        device.CreateHullShader(blob.GetBufferPointer(), blob.GetBufferSize(), classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11HullShader>(shader);
    }

    public static IComObject<ID3D11HullShader> CreateHullShader(this IComObject<ID3D11Device> device, IntPtr shaderBytecode, int bytecodeLength, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateHullShader(device?.Object!, shaderBytecode, bytecodeLength, classLinkage?.Object!);
    public static IComObject<ID3D11HullShader> CreateHullShader(this ID3D11Device device, IntPtr shaderBytecode, int bytecodeLength, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateHullShader(shaderBytecode, (IntPtr)bytecodeLength, classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11HullShader>(shader);
    }

    public static IComObject<ID3D11PixelShader> CreatePixelShader(this IComObject<ID3D11Device> device, IComObject<ID3DBlob> blob, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreatePixelShader(device?.Object!, blob?.Object!, classLinkage?.Object!);
    public static IComObject<ID3D11PixelShader> CreatePixelShader(this ID3D11Device device, ID3DBlob blob, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(blob);
        device.CreatePixelShader(blob.GetBufferPointer(), blob.GetBufferSize(), classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11PixelShader>(shader);
    }

    public static IComObject<ID3D11PixelShader> CreatePixelShader(this IComObject<ID3D11Device> device, IntPtr shaderBytecode, int bytecodeLength, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreatePixelShader(device?.Object!, shaderBytecode, bytecodeLength, classLinkage?.Object!);
    public static IComObject<ID3D11PixelShader> CreatePixelShader(this ID3D11Device device, IntPtr shaderBytecode, int bytecodeLength, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreatePixelShader(shaderBytecode, (IntPtr)bytecodeLength, classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11PixelShader>(shader);
    }

    public static IComObject<ID3D11GeometryShader> CreateGeometryShader(this IComObject<ID3D11Device> device, IComObject<ID3DBlob> blob, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateGeometryShader(device?.Object!, blob?.Object!, classLinkage?.Object!);
    public static IComObject<ID3D11GeometryShader> CreateGeometryShader(this ID3D11Device device, ID3DBlob blob, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateGeometryShader(blob.GetBufferPointer(), blob.GetBufferSize(), classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11GeometryShader>(shader);
    }

    public static IComObject<ID3D11GeometryShader> CreateGeometryShader(this IComObject<ID3D11Device> device, IntPtr shaderBytecode, int bytecodeLength, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateGeometryShader(device?.Object!, shaderBytecode, bytecodeLength, classLinkage?.Object!);
    public static IComObject<ID3D11GeometryShader> CreateGeometryShader(this ID3D11Device device, IntPtr shaderBytecode, int bytecodeLength, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateGeometryShader(shaderBytecode, (IntPtr)bytecodeLength, classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11GeometryShader>(shader);
    }

    public static IComObject<ID3D11VertexShader> CreateVertexShader(this IComObject<ID3D11Device> device, IComObject<ID3DBlob> blob, IComObject<ID3D11ClassLinkage> classLinkage = null) => CreateVertexShader(device?.Object!, blob?.Object!, classLinkage?.Object!);
    public static IComObject<ID3D11VertexShader> CreateVertexShader(this ID3D11Device device, ID3DBlob blob, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(blob);
        device.CreateVertexShader(blob.GetBufferPointer(), blob.GetBufferSize(), classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11VertexShader>(shader);
    }

    public static IComObject<ID3D11VertexShader> CreateVertexShader(this IComObject<ID3D11Device> device, IntPtr shaderBytecode, int bytecodeLength, ID3D11ClassLinkage classLinkage = null) => CreateVertexShader(device?.Object!, shaderBytecode, bytecodeLength, classLinkage);
    public static IComObject<ID3D11VertexShader> CreateVertexShader(this ID3D11Device device, IntPtr shaderBytecode, int bytecodeLength, ID3D11ClassLinkage classLinkage = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateVertexShader(shaderBytecode, (IntPtr)bytecodeLength, classLinkage, out var shader).ThrowOnError();
        return new ComObject<ID3D11VertexShader>(shader);
    }

    public static IComObject<ID3D11RenderTargetView> CreateRenderTargetView(this IComObject<ID3D11Device> device, IComObject<ID3D11Resource> resource, D3D11_RENDER_TARGET_VIEW_DESC? desc = null) => CreateRenderTargetView(device?.Object!, resource?.Object!, desc);
    public static IComObject<ID3D11RenderTargetView> CreateRenderTargetView(this ID3D11Device device, ID3D11Resource resource, D3D11_RENDER_TARGET_VIEW_DESC? desc = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(resource);
        using var mem = new ComMemory(desc);
        device.CreateRenderTargetView(resource, mem.Pointer, out var view).ThrowOnError();
        return new ComObject<ID3D11RenderTargetView>(view);
    }

    public static IComObject<ID3D11ShaderResourceView> CreateShaderResourceView(this IComObject<ID3D11Device> device, IComObject<ID3D11Resource> resource, D3D11_SHADER_RESOURCE_VIEW_DESC? desc = null) => CreateShaderResourceView(device?.Object!, resource?.Object!, desc);
    public static IComObject<ID3D11ShaderResourceView> CreateShaderResourceView(this ID3D11Device device, ID3D11Resource resource, D3D11_SHADER_RESOURCE_VIEW_DESC? desc = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(resource);
        using var mem = new ComMemory(desc);
        device.CreateShaderResourceView(resource, mem.Pointer, out var view).ThrowOnError();
        return new ComObject<ID3D11ShaderResourceView>(view);
    }

    public static IComObject<ID3D11UnorderedAccessView> CreateUnorderedAccessView(this IComObject<ID3D11Device> device, IComObject<ID3D11Resource> resource, D3D11_UNORDERED_ACCESS_VIEW_DESC? desc = null) => CreateUnorderedAccessView(device?.Object!, resource?.Object!, desc);
    public static IComObject<ID3D11UnorderedAccessView> CreateUnorderedAccessView(this ID3D11Device device, ID3D11Resource resource, D3D11_UNORDERED_ACCESS_VIEW_DESC? desc = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(resource);
        using var mem = new ComMemory(desc);
        device.CreateUnorderedAccessView(resource, mem.Pointer, out var view).ThrowOnError();
        return new ComObject<ID3D11UnorderedAccessView>(view);
    }

    public static IComObject<ID3D11DepthStencilView> CreateDepthStencilView(this IComObject<ID3D11Device> device, IComObject<ID3D11Resource> resource, D3D11_DEPTH_STENCIL_VIEW_DESC? desc = null) => CreateDepthStencilView(device?.Object!, resource?.Object!, desc);
    public static IComObject<ID3D11DepthStencilView> CreateDepthStencilView(this ID3D11Device device, ID3D11Resource resource, D3D11_DEPTH_STENCIL_VIEW_DESC? desc = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(resource);
        using var mem = new ComMemory(desc);
        device.CreateDepthStencilView(resource, mem.Pointer, out var view).ThrowOnError();
        return new ComObject<ID3D11DepthStencilView>(view);
    }

    public static IComObject<ID3D11InputLayout> CreateInputLayout(this IComObject<ID3D11Device> device, D3D11_INPUT_ELEMENT_DESC[] inputElements, IComObject<ID3DBlob> blob) => CreateInputLayout(device?.Object!, inputElements, blob?.Object!);
    public static IComObject<ID3D11InputLayout> CreateInputLayout(this ID3D11Device device, D3D11_INPUT_ELEMENT_DESC[] inputElements, ID3DBlob blob)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(blob);
        ArgumentNullException.ThrowIfNull(inputElements);
        if (inputElements.Length == 0)
            throw new ArgumentException(null, nameof(inputElements));

        foreach (var element in inputElements)
        {
            if (element.SemanticName == null)
                throw new ArgumentException(null, nameof(inputElements));
        }

        device.CreateInputLayout(inputElements, inputElements.Length, blob.GetBufferPointer(), blob.GetBufferSize(), out var layout).ThrowOnError();
        return new ComObject<ID3D11InputLayout>(layout);
    }

    public static IComObject<ID3D11InputLayout> CreateInputLayout(this IComObject<ID3D11Device> device, D3D11_INPUT_ELEMENT_DESC[] inputElements, IntPtr shaderBytecodeWithInputSignature, IntPtr bytecodeLength) => CreateInputLayout(device?.Object!, inputElements, shaderBytecodeWithInputSignature, bytecodeLength);
    public static IComObject<ID3D11InputLayout> CreateInputLayout(this ID3D11Device device, D3D11_INPUT_ELEMENT_DESC[] inputElements, IntPtr shaderBytecodeWithInputSignature, IntPtr bytecodeLength)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(inputElements);
        if (inputElements.Length == 0)
            throw new ArgumentException(null, nameof(inputElements));

        foreach (var element in inputElements)
        {
            if (element.SemanticName == null)
                throw new ArgumentException(null, nameof(inputElements));
        }

        device.CreateInputLayout(inputElements, inputElements.Length, shaderBytecodeWithInputSignature, bytecodeLength, out var layout).ThrowOnError();
        return new ComObject<ID3D11InputLayout>(layout);
    }

    public static IComObject<ID3D11DeviceContext>? GetImmediateContext(this IComObject<ID3D11Device> obj) => GetImmediateContext(obj?.Object!);
    public static IComObject<ID3D11DeviceContext>? GetImmediateContext(this ID3D11Device obj)
    {
        ArgumentNullException.ThrowIfNull(obj);
        obj.GetImmediateContext(out var value);
        return value != null ? new ComObject<ID3D11DeviceContext>(value) : null;
    }
}
