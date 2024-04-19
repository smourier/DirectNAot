namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11depthstencilview
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6")]
public partial interface ID3D11DepthStencilView : ID3D11View
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11depthstencilview-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_DEPTH_STENCIL_VIEW_DESC pDesc);
}
