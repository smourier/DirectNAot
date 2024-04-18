namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11resource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d")]
public partial interface ID3D11Resource : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11resource-gettype
    [PreserveSig]
    public void GetType(out D3D11_RESOURCE_DIMENSION pResourceDimension);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11resource-setevictionpriority
    [PreserveSig]
    public void SetEvictionPriority(uint EvictionPriority);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11resource-getevictionpriority
    [PreserveSig]
    public uint GetEvictionPriority();
}
