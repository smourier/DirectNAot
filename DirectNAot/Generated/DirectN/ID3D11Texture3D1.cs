#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11texture3d1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("0c711683-2853-4846-9bb0-f3e60639e46a")]
public partial interface ID3D11Texture3D1 : ID3D11Texture3D
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11texture3d1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D11_TEXTURE3D_DESC1 pDesc);
}
