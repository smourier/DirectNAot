#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device4
[GeneratedComInterface, Guid("e865df17-a9ee-46f9-a463-3098315aa2e5")]
public partial interface ID3D12Device4 : ID3D12Device3
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device4-createcommandlist1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommandList1(uint nodeMask, D3D12_COMMAND_LIST_TYPE type, D3D12_COMMAND_LIST_FLAGS flags, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppCommandList);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device4-createprotectedresourcesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateProtectedResourceSession(in D3D12_PROTECTED_RESOURCE_SESSION_DESC pDesc, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device4-createcommittedresource1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommittedResource1(in D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, in D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, nint /* optional D3D12_CLEAR_VALUE* */ pOptimizedClearValue, ID3D12ProtectedResourceSession? pProtectedSession, in Guid riidResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device4-createheap1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateHeap1(in D3D12_HEAP_DESC pDesc, ID3D12ProtectedResourceSession? pProtectedSession, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvHeap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device4-createreservedresource1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReservedResource1(in D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, nint /* optional D3D12_CLEAR_VALUE* */ pOptimizedClearValue, ID3D12ProtectedResourceSession? pProtectedSession, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device4-getresourceallocationinfo1
    [PreserveSig]
    D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, [In][MarshalUsing(CountElementName = nameof(numResourceDescs))] D3D12_RESOURCE_DESC[] pResourceDescs, nint /* optional D3D12_RESOURCE_ALLOCATION_INFO1* */ pResourceAllocationInfo1);
}
