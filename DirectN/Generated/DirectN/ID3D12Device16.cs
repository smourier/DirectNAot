#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b34a50dd-e102-428f-82a0-82294a27bbe6")]
public partial interface ID3D12Device16 : ID3D12Device15
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextureLayoutCount(in D3D12_TEXTURE_LAYOUT_FILTER pFilter, out uint pNumGuids);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextureLayouts(in D3D12_TEXTURE_LAYOUT_FILTER pFilter, uint NumGuids, [In][Out][MarshalUsing(CountElementName = nameof(NumGuids))] Guid[] pGuids);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommittedResource4(in D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, in D3D12_RESOURCE_DESC2 pResourceDesc, D3D12_BARRIER_LAYOUT InitialLayout, nint /* optional D3D12_CLEAR_VALUE* */ pOptimizedClearValue, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12ProtectedResourceSession?>))] ID3D12ProtectedResourceSession? pProtectedSession, uint NumCastableFormats, nint /* optional DXGI_FORMAT* */ pCastableFormats, in Guid riidResource, out nint /* void */ ppvResource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePlacedResource3([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Heap>))] ID3D12Heap pHeap, ulong HeapOffset, in D3D12_RESOURCE_DESC2 pResourceDesc, D3D12_BARRIER_LAYOUT InitialLayout, nint /* optional D3D12_CLEAR_VALUE* */ pOptimizedClearValue, uint NumCastableFormats, nint /* optional DXGI_FORMAT* */ pCastableFormats, in Guid riid, out nint /* void */ ppvResource);
    
    [PreserveSig]
    D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo4(uint visibleMask, uint numResourceDescs, [In][MarshalUsing(CountElementName = nameof(numResourceDescs))] D3D12_RESOURCE_DESC2[] pResourceDescs, nint /* optional uint* */ pNumCastableFormats, nint /* optional DXGI_FORMAT** */ ppCastableFormats, nint /* optional D3D12_RESOURCE_ALLOCATION_INFO1* */ pResourceAllocationInfo1);
    
    [PreserveSig]
    void GetCopyableFootprints2(in D3D12_RESOURCE_DESC2 __MIDL__ID3D12Device160000, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, nint /* optional D3D12_PLACED_SUBRESOURCE_FOOTPRINT* */ __MIDL__ID3D12Device160001, nint /* optional uint* */ pNumRows, nint /* optional ulong* */ pRowSizeInBytes, nint /* optional ulong* */ pTotalBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRowMajorTextureLayoutInfo(in D3D12_RESOURCE_DESC2 pResourceDesc, uint FirstSubresource, uint NumSubresources, nint /* optional D3D12_ROW_MAJOR_TEXTURE_LAYOUT_INFO* */ pLayoutInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateShaderCacheSession1(in D3D12_SHADER_CACHE_SESSION_DESC1 pDesc, in Guid riid, out nint /* void */ ppvSession);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteShaderCache(in D3D12_SHADER_CACHE_SESSION_DESC1 pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFeatureSupport1(D3D12_FEATURE Feature, nint pFeatureSupportData, uint FeatureSupportDataSize, uint SDKVersion);
}
