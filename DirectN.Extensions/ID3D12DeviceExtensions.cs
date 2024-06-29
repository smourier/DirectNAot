namespace DirectN;

public static class ID3D12DeviceExtensions
{
    public static IComObject<ID3D12CommandAllocator> CreateCommandAllocator(this IComObject<ID3D12Device> device, D3D12_COMMAND_LIST_TYPE type) => CreateCommandAllocator(device?.Object!, type);
    public static IComObject<ID3D12CommandAllocator> CreateCommandAllocator(this ID3D12Device device, D3D12_COMMAND_LIST_TYPE type)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateCommandAllocator(type, typeof(ID3D12CommandAllocator).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<ID3D12CommandAllocator>(unk)!;
    }

    public static IComObject<ID3D12CommandList> CreateCommandList(this IComObject<ID3D12Device> device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, IComObject<ID3D12CommandAllocator> commandAllocator, IComObject<ID3D12PipelineState>? initialState = null) => CreateCommandList<ID3D12CommandList>(device?.Object!, nodeMask, type, commandAllocator?.Object!, initialState?.Object!);
    public static IComObject<ID3D12CommandList> CreateCommandList(this ID3D12Device device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator commandAllocator, ID3D12PipelineState? initialState = null) => CreateCommandList<ID3D12CommandList>(device, nodeMask, type, commandAllocator, initialState);
    public static IComObject<T> CreateCommandList<T>(this IComObject<ID3D12Device> device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, IComObject<ID3D12CommandAllocator> commandAllocator, IComObject<ID3D12PipelineState>? initialState = null) where T : ID3D12CommandList => CreateCommandList<T>(device?.Object!, nodeMask, type, commandAllocator?.Object!, initialState?.Object!);
    public static IComObject<T> CreateCommandList<T>(this ID3D12Device device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator commandAllocator, ID3D12PipelineState? initialState = null) where T : ID3D12CommandList
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateCommandList(nodeMask, type, commandAllocator, initialState, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static IComObject<ID3D12CommandQueue> CreateCommandQueue(this IComObject<ID3D12Device> device, D3D12_COMMAND_QUEUE_DESC desc) => CreateCommandQueue(device?.Object!, desc);
    public static IComObject<ID3D12CommandQueue> CreateCommandQueue(this ID3D12Device device, D3D12_COMMAND_QUEUE_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateCommandQueue(desc, typeof(ID3D12CommandQueue).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<ID3D12CommandQueue>(unk)!;
    }

    public static IComObject<ID3D12DescriptorHeap> CreateDescriptorHeap(this IComObject<ID3D12Device> device, D3D12_DESCRIPTOR_HEAP_DESC desc) => CreateDescriptorHeap(device?.Object!, desc);
    public static IComObject<ID3D12DescriptorHeap> CreateDescriptorHeap(this ID3D12Device device, D3D12_DESCRIPTOR_HEAP_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateDescriptorHeap(desc, typeof(ID3D12DescriptorHeap).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<ID3D12DescriptorHeap>(unk)!;
    }

    public static IComObject<ID3D12PipelineState> CreateGraphicsPipelineState(this IComObject<ID3D12Device> device, D3D12_GRAPHICS_PIPELINE_STATE_DESC desc) => CreateGraphicsPipelineState(device?.Object!, desc);
    public static IComObject<ID3D12PipelineState> CreateGraphicsPipelineState(this ID3D12Device device, D3D12_GRAPHICS_PIPELINE_STATE_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateGraphicsPipelineState(desc, typeof(ID3D12PipelineState).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<ID3D12PipelineState>(unk)!;
    }

    public static IComObject<ID3D12PipelineState> CreateComputePipelineState(this IComObject<ID3D12Device> device, D3D12_COMPUTE_PIPELINE_STATE_DESC desc) => CreateComputePipelineState(device?.Object!, desc);
    public static IComObject<ID3D12PipelineState> CreateComputePipelineState(this ID3D12Device device, D3D12_COMPUTE_PIPELINE_STATE_DESC desc)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateComputePipelineState(desc, typeof(ID3D12PipelineState).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<ID3D12PipelineState>(unk)!;
    }

    public static IComObject<ID3D12RootSignature> CreateRootSignature(this IComObject<ID3D12Device> device, uint nodeMask, nint blobWithRootSignature, nuint blobLengthInBytes) => CreateRootSignature(device?.Object!, nodeMask, blobWithRootSignature, blobLengthInBytes);
    public static IComObject<ID3D12RootSignature> CreateRootSignature(this ID3D12Device device, uint nodeMask, nint blobWithRootSignature, nuint blobLengthInBytes)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateRootSignature(nodeMask, blobWithRootSignature, blobLengthInBytes, typeof(ID3D12RootSignature).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<ID3D12RootSignature>(unk)!;
    }

    public static IComObject<ID3D12Heap> CreateHeap(this IComObject<ID3D12Device> device, D3D12_HEAP_DESC desc) => CreateHeap<ID3D12Heap>(device?.Object!, desc);
    public static IComObject<ID3D12Heap> CreateHeap(this ID3D12Device device, D3D12_HEAP_DESC desc) => CreateHeap<ID3D12Heap>(device, desc);
    public static IComObject<T> CreateHeap<T>(this IComObject<ID3D12Device> device, D3D12_HEAP_DESC desc) where T : ID3D12Heap => CreateHeap<T>(device?.Object!, desc);
    public static IComObject<T> CreateHeap<T>(this ID3D12Device device, D3D12_HEAP_DESC desc) where T : ID3D12Heap
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateHeap(desc, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static void CopyDescriptorsSimple(this IComObject<ID3D12Device> device, int numDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE destDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE srcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE descriptorHeapsType) => CopyDescriptorsSimple(device?.Object!, numDescriptors, destDescriptorRangeStart, srcDescriptorRangeStart, descriptorHeapsType);
    public static void CopyDescriptorsSimple(this ID3D12Device device, int numDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE destDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE srcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE descriptorHeapsType)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CopyDescriptorsSimple(numDescriptors, destDescriptorRangeStart, srcDescriptorRangeStart, descriptorHeapsType);
    }

    public static uint GetDescriptorHandleIncrementSize(this IComObject<ID3D12Device> device, D3D12_DESCRIPTOR_HEAP_TYPE type) => GetDescriptorHandleIncrementSize(device?.Object!, type);
    public static uint GetDescriptorHandleIncrementSize(this ID3D12Device device, D3D12_DESCRIPTOR_HEAP_TYPE type)
    {
        ArgumentNullException.ThrowIfNull(device);
        return device.GetDescriptorHandleIncrementSize(type);
    }

    public static uint GetNodeCount(this IComObject<ID3D12Device> device) => GetNodeCount(device?.Object!);
    public static uint GetNodeCount(this ID3D12Device device)
    {
        ArgumentNullException.ThrowIfNull(device);
        return device.GetNodeCount();
    }

    public static LUID GetAdapterLuid(this IComObject<ID3D12Device> device) => GetAdapterLuid(device?.Object!);
    public static LUID GetAdapterLuid(this ID3D12Device device)
    {
        ArgumentNullException.ThrowIfNull(device);
        return device.GetAdapterLuid();
    }

    public static IComObject<ID3D12Fence> CreateFence(this IComObject<ID3D12Device> device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) => CreateFence<ID3D12Fence>(device.Object, initialValue, flags);
    public static IComObject<ID3D12Fence> CreateFence(this ID3D12Device device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) => CreateFence<ID3D12Fence>(device, initialValue, flags);
    public static IComObject<T> CreateFence<T>(this IComObject<ID3D12Device> device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) where T : ID3D12Fence => CreateFence<T>(device.Object, initialValue, flags);
    public static IComObject<T> CreateFence<T>(this ID3D12Device device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) where T : ID3D12Fence
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateFence(initialValue, flags, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static IComObject<ID3D12Resource> CreateCommittedResource(this IComObject<ID3D12Device> device, D3D12_HEAP_PROPERTIES heapProperties, D3D12_HEAP_FLAGS heapFlags, D3D12_RESOURCE_DESC desc, D3D12_RESOURCE_STATES initialResourceState, D3D12_CLEAR_VALUE? optimizedClearValue = null) => CreateCommittedResource<ID3D12Resource>(device?.Object!, heapProperties, heapFlags, desc, initialResourceState, optimizedClearValue);
    public static IComObject<ID3D12Resource> CreateCommittedResource(this ID3D12Device device, D3D12_HEAP_PROPERTIES heapProperties, D3D12_HEAP_FLAGS heapFlags, D3D12_RESOURCE_DESC desc, D3D12_RESOURCE_STATES initialResourceState, D3D12_CLEAR_VALUE? optimizedClearValue = null) => CreateCommittedResource<ID3D12Resource>(device, heapProperties, heapFlags, desc, initialResourceState, optimizedClearValue);
    public static IComObject<T> CreateCommittedResource<T>(this IComObject<ID3D12Device> device, D3D12_HEAP_PROPERTIES heapProperties, D3D12_HEAP_FLAGS heapFlags, D3D12_RESOURCE_DESC desc, D3D12_RESOURCE_STATES initialResourceState, D3D12_CLEAR_VALUE? optimizedClearValue = null) where T : ID3D12Resource => CreateCommittedResource<T>(device?.Object!, heapProperties, heapFlags, desc, initialResourceState, optimizedClearValue);
    public static IComObject<T> CreateCommittedResource<T>(this ID3D12Device device, D3D12_HEAP_PROPERTIES heapProperties, D3D12_HEAP_FLAGS heapFlags, D3D12_RESOURCE_DESC desc, D3D12_RESOURCE_STATES initialResourceState, D3D12_CLEAR_VALUE? optimizedClearValue = null) where T : ID3D12Resource
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateCommittedResource(heapProperties, heapFlags, desc, initialResourceState, optimizedClearValue.CopyToPointer(), typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static void CreateRenderTargetView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateRenderTargetView(device?.Object!, resource?.Object!, desc, handle);
    public static void CreateRenderTargetView(this ID3D12Device device, ID3D12Resource resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateRenderTargetView(resource, desc.CopyToPointer(), handle);
    }

    public static void CreateConstantBufferView(this IComObject<ID3D12Device> device, D3D12_CONSTANT_BUFFER_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateConstantBufferView(device?.Object!, desc, handle);
    public static void CreateConstantBufferView(this ID3D12Device device, D3D12_CONSTANT_BUFFER_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateConstantBufferView(desc.CopyToPointer(), handle);
    }

    public static void CreateSampler(this IComObject<ID3D12Device> device, D3D12_SAMPLER_DESC desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateSampler(device?.Object!, desc, handle);
    public static void CreateSampler(this ID3D12Device device, D3D12_SAMPLER_DESC desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateSampler(desc, handle);
    }

    public static void CreateShaderResourceView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateShaderResourceView(device?.Object!, resource?.Object!, desc, handle);
    public static void CreateShaderResourceView(this ID3D12Device device, ID3D12Resource resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateShaderResourceView(resource, desc.CopyToPointer(), handle);
    }

    public static void CreateDepthStencilView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateDepthStencilView(device?.Object!, resource?.Object!, desc, handle);
    public static void CreateDepthStencilView(this ID3D12Device device, ID3D12Resource resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateDepthStencilView(resource, desc.CopyToPointer(), handle);
    }

    public static void CreateUnorderedAccessView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, IComObject<ID3D12Resource> counterResource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateUnorderedAccessView(device?.Object!, resource?.Object!, counterResource?.Object!, desc, handle);
    public static void CreateUnorderedAccessView(this ID3D12Device device, ID3D12Resource resource, ID3D12Resource counterResource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateUnorderedAccessView(resource, counterResource, desc.CopyToPointer(), handle);
    }

    public static HRESULT CheckFeatureSupport<T>(this IComObject<ID3D12Device> device, D3D12_FEATURE feature, ref T value) where T : unmanaged => CheckFeatureSupport(device.Object!, feature, ref value);
    public unsafe static HRESULT CheckFeatureSupport<T>(this ID3D12Device device, D3D12_FEATURE feature, ref T value) where T : unmanaged
    {
        ArgumentNullException.ThrowIfNull(device);
        return device.CheckFeatureSupport(feature, (nint)Unsafe.AsPointer(ref value), (uint)sizeof(T));
    }
}
