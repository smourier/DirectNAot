#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10texture1d
[GeneratedComInterface, Guid("9b7e4c03-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Texture1D : ID3D10Resource
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10texture1d-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Map(uint Subresource, D3D10_MAP MapType, uint MapFlags, out nint ppData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10texture1d-unmap
    [PreserveSig]
    void Unmap(uint Subresource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10texture1d-getdesc
    [PreserveSig]
    void GetDesc(out D3D10_TEXTURE1D_DESC pDesc);
}
