#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11texture2d
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c")]
public partial interface ID3D11Texture2D : ID3D11Resource
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11texture2d-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_TEXTURE2D_DESC pDesc);
}
