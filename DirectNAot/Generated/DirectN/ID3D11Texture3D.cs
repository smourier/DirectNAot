namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11texture3d
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("037e866e-f56d-4357-a8af-9dabbe6e250e")]
public partial interface ID3D11Texture3D : ID3D11Resource
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11texture3d-getdesc
    [PreserveSig]
    public void GetDesc(out D3D11_TEXTURE3D_DESC pDesc);
}
