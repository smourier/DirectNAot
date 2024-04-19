namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device8
[GeneratedComInterface, Guid("9218e6bb-f944-4f7e-a75c-b1b2c7b701f3")]
public partial interface ID3D12Device8 : ID3D12Device7
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device8-getresourceallocationinfo2
    [PreserveSig]
    D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo2(uint visibleMask, uint numResourceDescs, in D3D12_RESOURCE_DESC1 pResourceDescs, nint/* nint */ pResourceAllocationInfo1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device8-createcommittedresource2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommittedResource2(in D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, in D3D12_RESOURCE_DESC1 pDesc, D3D12_RESOURCE_STATES InitialResourceState, nint/* nint */ pOptimizedClearValue, ID3D12ProtectedResourceSession pProtectedSession, in Guid riidResource, nint/* nint */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device8-createplacedresource1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePlacedResource1(ID3D12Heap pHeap, ulong HeapOffset, in D3D12_RESOURCE_DESC1 pDesc, D3D12_RESOURCE_STATES InitialState, nint/* nint */ pOptimizedClearValue, in Guid riid, nint/* nint */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device8-createsamplerfeedbackunorderedaccessview
    [PreserveSig]
    void CreateSamplerFeedbackUnorderedAccessView(ID3D12Resource pTargetedResource, ID3D12Resource pFeedbackResource, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device8-getcopyablefootprints1
    [PreserveSig]
    void GetCopyableFootprints1(in D3D12_RESOURCE_DESC1 pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, nint/* nint */ pLayouts, nint/* nint */ pNumRows, nint/* nint */ pRowSizeInBytes, nint/* nint */ pTotalBytes);
}
