#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1/nn-d3d10_1-id3d10blendstate1
[GeneratedComInterface, Guid("edad8d99-8a35-4d6d-8566-2ea276cde161")]
public partial interface ID3D10BlendState1 : ID3D10BlendState
{
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-id3d10blendstate1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D10_BLEND_DESC1 pDesc);
}
