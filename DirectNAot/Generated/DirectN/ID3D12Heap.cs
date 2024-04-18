namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12heap
[GeneratedComInterface, Guid("6b3b2502-6e51-45b3-90ee-9884265e8df3")]
public partial interface ID3D12Heap : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/direct3d12/id3d12heap-getdesc
    [PreserveSig]
    public D3D12_HEAP_DESC GetDesc();
}
