namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11rasterizerstate
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7")]
public partial interface ID3D11RasterizerState : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11rasterizerstate-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_RASTERIZER_DESC pDesc);
}
