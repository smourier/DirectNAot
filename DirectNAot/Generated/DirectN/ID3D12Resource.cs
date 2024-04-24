namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12resource
[GeneratedComInterface, Guid("696442be-a72e-4059-bc79-5b5c98040fad")]
public partial interface ID3D12Resource : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Map(uint Subresource, nint /* optional D3D12_RANGE* */ pReadRange, nint /* optional void** */ ppData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-unmap
    [PreserveSig]
    void Unmap(uint Subresource, nint /* optional D3D12_RANGE* */ pWrittenRange);
    
    // https://learn.microsoft.com/windows/win32/direct3d12/id3d12resource-getdesc
    [PreserveSig]
    D3D12_RESOURCE_DESC GetDesc();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-getgpuvirtualaddress
    [PreserveSig]
    ulong GetGPUVirtualAddress();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-writetosubresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteToSubresource(uint DstSubresource, nint /* optional D3D12_BOX* */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-readfromsubresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadFromSubresource(nint pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, nint /* optional D3D12_BOX* */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-getheapproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeapProperties(nint /* optional D3D12_HEAP_PROPERTIES* */ pHeapProperties, nint /* optional D3D12_HEAP_FLAGS* */ pHeapFlags);
}
