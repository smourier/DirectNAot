namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device10
[GeneratedComInterface, Guid("517f8718-aa66-49f9-b02b-a7ab89c06031")]
public partial interface ID3D12Device10 : ID3D12Device9
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device10-createcommittedresource3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCommittedResource3(in D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, in D3D12_RESOURCE_DESC1 pDesc, D3D12_BARRIER_LAYOUT InitialLayout, nint/* nint */ pOptimizedClearValue, ID3D12ProtectedResourceSession pProtectedSession, uint NumCastableFormats, nint/* nint */ pCastableFormats, in Guid riidResource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device10-createplacedresource2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePlacedResource2(ID3D12Heap pHeap, ulong HeapOffset, in D3D12_RESOURCE_DESC1 pDesc, D3D12_BARRIER_LAYOUT InitialLayout, nint/* nint */ pOptimizedClearValue, uint NumCastableFormats, nint/* nint */ pCastableFormats, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device10-createreservedresource2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateReservedResource2(in D3D12_RESOURCE_DESC pDesc, D3D12_BARRIER_LAYOUT InitialLayout, nint/* nint */ pOptimizedClearValue, ID3D12ProtectedResourceSession pProtectedSession, uint NumCastableFormats, nint/* nint */ pCastableFormats, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvResource);
}
