namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device
[GeneratedComInterface, Guid("189819f1-1db6-4b57-be54-1821339b85f7")]
public partial interface ID3D12Device : ID3D12Object
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getnodecount
    [PreserveSig]
    uint GetNodeCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createcommandqueue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommandQueue(in D3D12_COMMAND_QUEUE_DESC pDesc, in Guid riid, out nint ppCommandQueue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createcommandallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, in Guid riid, out nint ppCommandAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-creategraphicspipelinestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGraphicsPipelineState(in D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, in Guid riid, out nint ppPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createcomputepipelinestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateComputePipelineState(in D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, in Guid riid, out nint ppPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createcommandlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommandList(uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, in Guid riid, out nint ppCommandList);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-checkfeaturesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFeatureSupport(D3D12_FEATURE Feature, nint pFeatureSupportData, uint FeatureSupportDataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createdescriptorheap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDescriptorHeap(in D3D12_DESCRIPTOR_HEAP_DESC pDescriptorHeapDesc, in Guid riid, out nint ppvHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getdescriptorhandleincrementsize
    [PreserveSig]
    uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createrootsignature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRootSignature(uint nodeMask, nint pBlobWithRootSignature, nuint blobLengthInBytes, in Guid riid, out nint ppvRootSignature);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createconstantbufferview
    [PreserveSig]
    void CreateConstantBufferView(nint/* nint */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createshaderresourceview
    [PreserveSig]
    void CreateShaderResourceView(ID3D12Resource pResource, nint/* nint */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createunorderedaccessview
    [PreserveSig]
    void CreateUnorderedAccessView(ID3D12Resource pResource, ID3D12Resource pCounterResource, nint/* nint */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createrendertargetview
    [PreserveSig]
    void CreateRenderTargetView(ID3D12Resource pResource, nint/* nint */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createdepthstencilview
    [PreserveSig]
    void CreateDepthStencilView(ID3D12Resource pResource, nint/* nint */ pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createsampler
    [PreserveSig]
    void CreateSampler(in D3D12_SAMPLER_DESC pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-copydescriptors
    [PreserveSig]
    void CopyDescriptors(uint NumDestDescriptorRanges, in D3D12_CPU_DESCRIPTOR_HANDLE pDestDescriptorRangeStarts, nint/* nint */ pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, in D3D12_CPU_DESCRIPTOR_HANDLE pSrcDescriptorRangeStarts, nint/* nint */ pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-copydescriptorssimple
    [PreserveSig]
    void CopyDescriptorsSimple(uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getresourceallocationinfo
    [PreserveSig]
    D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, in D3D12_RESOURCE_DESC pResourceDescs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getcustomheapproperties
    [PreserveSig]
    D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createcommittedresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommittedResource(in D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, in D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, nint/* nint */ pOptimizedClearValue, in Guid riidResource, nint/* nint */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createheap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateHeap(in D3D12_HEAP_DESC pDesc, in Guid riid, nint/* nint */ ppvHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createplacedresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePlacedResource(ID3D12Heap pHeap, ulong HeapOffset, in D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, nint/* nint */ pOptimizedClearValue, in Guid riid, nint/* nint */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createreservedresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReservedResource(in D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, nint/* nint */ pOptimizedClearValue, in Guid riid, nint/* nint */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createsharedhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSharedHandle(ID3D12DeviceChild pObject, nint/* nint */ pAttributes, uint Access, PWSTR Name, out HANDLE pHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-opensharedhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenSharedHandle(HANDLE NTHandle, in Guid riid, nint/* nint */ ppvObj);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-opensharedhandlebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenSharedHandleByName(PWSTR Name, uint Access, out HANDLE pNTHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-makeresident
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeResident(uint NumObjects, in ID3D12Pageable ppObjects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-evict
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Evict(uint NumObjects, in ID3D12Pageable ppObjects);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createfence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFence(ulong InitialValue, D3D12_FENCE_FLAGS Flags, in Guid riid, out nint ppFence);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getdeviceremovedreason
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceRemovedReason();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getcopyablefootprints
    [PreserveSig]
    void GetCopyableFootprints(in D3D12_RESOURCE_DESC pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, nint/* nint */ pLayouts, nint/* nint */ pNumRows, nint/* nint */ pRowSizeInBytes, nint/* nint */ pTotalBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createqueryheap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQueryHeap(in D3D12_QUERY_HEAP_DESC pDesc, in Guid riid, nint/* nint */ ppvHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-setstablepowerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStablePowerState([MarshalAs(UnmanagedType.U4)] bool Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-createcommandsignature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommandSignature(in D3D12_COMMAND_SIGNATURE_DESC pDesc, ID3D12RootSignature pRootSignature, in Guid riid, nint/* nint */ ppvCommandSignature);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getresourcetiling
    [PreserveSig]
    void GetResourceTiling(ID3D12Resource pTiledResource, nint/* nint */ pNumTilesForEntireResource, nint/* nint */ pPackedMipDesc, nint/* nint */ pStandardTileShapeForNonPackedMips, nint/* nint */ pNumSubresourceTilings, uint FirstSubresourceTilingToGet, out D3D12_SUBRESOURCE_TILING pSubresourceTilingsForNonPackedMips);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device-getadapterluid
    [PreserveSig]
    LUID GetAdapterLuid();
}
