namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11buffer
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("48570b85-d1ee-4fcd-a250-eb350722b037")]
public partial interface ID3D11Buffer : ID3D11Resource
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11buffer-getdesc
    [PreserveSig]
    public void GetDesc(out D3D11_BUFFER_DESC pDesc);
}
