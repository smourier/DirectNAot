namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11rasterizerstate1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("1217d7a6-5039-418c-b042-9cbe256afd6e")]
public partial interface ID3D11RasterizerState1 : ID3D11RasterizerState
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11rasterizerstate1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D11_RASTERIZER_DESC1 pDesc);
}
