namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10texture3d
[GeneratedComInterface, Guid("9b7e4c05-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Texture3D : ID3D10Resource
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10texture3d-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Map(uint Subresource, D3D10_MAP MapType, uint MapFlags, out D3D10_MAPPED_TEXTURE3D pMappedTex3D);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10texture3d-unmap
    [PreserveSig]
    public void Unmap(uint Subresource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10texture3d-getdesc
    [PreserveSig]
    public void GetDesc(out D3D10_TEXTURE3D_DESC pDesc);
}
