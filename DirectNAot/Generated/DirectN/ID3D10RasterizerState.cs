#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10rasterizerstate
[GeneratedComInterface, Guid("a2a07292-89af-4345-be2e-c53d9fbb6e9f")]
public partial interface ID3D10RasterizerState : ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10rasterizerstate-getdesc
    [PreserveSig]
    void GetDesc(out D3D10_RASTERIZER_DESC pDesc);
}
