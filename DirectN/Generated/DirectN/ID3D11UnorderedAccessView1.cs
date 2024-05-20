#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11unorderedaccessview1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("7b3b6153-a886-4544-ab37-6537c8500403")]
public partial interface ID3D11UnorderedAccessView1 : ID3D11UnorderedAccessView
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11unorderedaccessview1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D11_UNORDERED_ACCESS_VIEW_DESC1 pDesc1);
}
