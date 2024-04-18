namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12resource
[GeneratedComInterface, Guid("696442be-a72e-4059-bc79-5b5c98040fad")]
public partial interface ID3D12Resource : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Map(uint Subresource, nint/* nint */ pReadRange, nint/* nint */ ppData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-unmap
    [PreserveSig]
    public void Unmap(uint Subresource, nint/* nint */ pWrittenRange);
    
    // https://learn.microsoft.com/windows/win32/direct3d12/id3d12resource-getdesc
    [PreserveSig]
    public D3D12_RESOURCE_DESC GetDesc();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-getgpuvirtualaddress
    [PreserveSig]
    public ulong GetGPUVirtualAddress();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-writetosubresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WriteToSubresource(uint DstSubresource, nint/* nint */ pDstBox, nint pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-readfromsubresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReadFromSubresource(nint pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, nint/* nint */ pSrcBox);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12resource-getheapproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetHeapProperties(nint/* nint */ pHeapProperties, nint/* nint */ pHeapFlags);
}
