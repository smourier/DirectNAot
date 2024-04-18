namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11depthstencilstate
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("03823efb-8d8f-4e1c-9aa2-f64bb2cbfdf1")]
public partial interface ID3D11DepthStencilState : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11depthstencilstate-getdesc
    [PreserveSig]
    public void GetDesc(out D3D11_DEPTH_STENCIL_DESC pDesc);
}
