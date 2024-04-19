namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11blendstate1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("cc86fabe-da55-401d-85e7-e3c9de2877e9")]
public partial interface ID3D11BlendState1 : ID3D11BlendState
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11blendstate1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D11_BLEND_DESC1 pDesc);
}
