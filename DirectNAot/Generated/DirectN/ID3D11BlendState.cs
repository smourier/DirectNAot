namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11blendstate
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("75b68faa-347d-4159-8f45-a0640f01cd9a")]
public partial interface ID3D11BlendState : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11blendstate-getdesc
    [PreserveSig]
    public void GetDesc(out D3D11_BLEND_DESC pDesc);
}
