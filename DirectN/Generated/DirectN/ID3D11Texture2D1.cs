#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11texture2d1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("51218251-1e33-4617-9ccb-4d3a4367e7bb")]
public partial interface ID3D11Texture2D1 : ID3D11Texture2D
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11texture2d1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D11_TEXTURE2D_DESC1 pDesc);
}
