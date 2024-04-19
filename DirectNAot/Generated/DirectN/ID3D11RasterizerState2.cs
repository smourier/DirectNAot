namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11rasterizerstate2
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("6fbd02fb-209f-46c4-b059-2ed15586a6ac")]
public partial interface ID3D11RasterizerState2 : ID3D11RasterizerState1
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11rasterizerstate2-getdesc2
    [PreserveSig]
    void GetDesc2(out D3D11_RASTERIZER_DESC2 pDesc);
}
