namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11rendertargetview1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("ffbe2e23-f011-418a-ac56-5ceed7c5b94b")]
public partial interface ID3D11RenderTargetView1 : ID3D11RenderTargetView
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11rendertargetview1-getdesc1
    [PreserveSig]
    public void GetDesc1(out D3D11_RENDER_TARGET_VIEW_DESC1 pDesc1);
}
