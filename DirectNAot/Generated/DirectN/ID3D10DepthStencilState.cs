namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10depthstencilstate
[GeneratedComInterface, Guid("2b4b1cc8-a4ad-41f8-8322-ca86fc3ec675")]
public partial interface ID3D10DepthStencilState : ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10depthstencilstate-getdesc
    [PreserveSig]
    public void GetDesc(out D3D10_DEPTH_STENCIL_DESC pDesc);
}
