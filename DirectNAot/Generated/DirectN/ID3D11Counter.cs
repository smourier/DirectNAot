namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11counter
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6e8c49fb-a371-4770-b440-29086022b741")]
public partial interface ID3D11Counter : ID3D11Asynchronous
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11counter-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_COUNTER_DESC pDesc);
}
