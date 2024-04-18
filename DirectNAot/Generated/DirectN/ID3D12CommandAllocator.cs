namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12commandallocator
[GeneratedComInterface, Guid("6102dee4-af59-4b09-b999-b44d73f09b24")]
public partial interface ID3D12CommandAllocator : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandallocator-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Reset();
}
