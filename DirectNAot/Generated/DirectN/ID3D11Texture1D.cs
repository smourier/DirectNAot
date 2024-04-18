namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11texture1d
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f8fb5c27-c6b3-4f75-a4c8-439af2ef564c")]
public partial interface ID3D11Texture1D : ID3D11Resource
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11texture1d-getdesc
    [PreserveSig]
    public void GetDesc(out D3D11_TEXTURE1D_DESC pDesc);
}
