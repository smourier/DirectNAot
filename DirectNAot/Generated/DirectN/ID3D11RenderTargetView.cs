namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11rendertargetview
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("dfdba067-0b8d-4865-875b-d7b4516cc164")]
public partial interface ID3D11RenderTargetView : ID3D11View
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11rendertargetview-getdesc
    [PreserveSig]
    public void GetDesc(out D3D11_RENDER_TARGET_VIEW_DESC pDesc);
}
