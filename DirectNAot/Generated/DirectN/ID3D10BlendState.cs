#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10blendstate
[GeneratedComInterface, Guid("edad8d19-8a35-4d6d-8566-2ea276cde161")]
public partial interface ID3D10BlendState : ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10blendstate-getdesc
    [PreserveSig]
    void GetDesc(out D3D10_BLEND_DESC pDesc);
}
