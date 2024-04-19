namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11unorderedaccessview
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("28acf509-7f5c-48f6-8611-f316010a6380")]
public partial interface ID3D11UnorderedAccessView : ID3D11View
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11unorderedaccessview-getdesc
    [PreserveSig]
    void GetDesc(out D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc);
}
