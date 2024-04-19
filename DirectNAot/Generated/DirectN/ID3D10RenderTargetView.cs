namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10rendertargetview
[GeneratedComInterface, Guid("9b7e4c08-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10RenderTargetView : ID3D10View
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10rendertargetview-getdesc
    [PreserveSig]
    void GetDesc(out D3D10_RENDER_TARGET_VIEW_DESC pDesc);
}
