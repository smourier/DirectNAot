namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10resource
[GeneratedComInterface, Guid("9b7e4c01-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Resource : ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10resource-gettype
    [PreserveSig]
    public void GetType(out D3D10_RESOURCE_DIMENSION rType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10resource-setevictionpriority
    [PreserveSig]
    public void SetEvictionPriority(uint EvictionPriority);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10resource-getevictionpriority
    [PreserveSig]
    public uint GetEvictionPriority();
}
