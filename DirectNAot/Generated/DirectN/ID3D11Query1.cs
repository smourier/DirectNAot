#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11query1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("631b4766-36dc-461d-8db6-c47e13e60916")]
public partial interface ID3D11Query1 : ID3D11Query
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11query1-getdesc1
    [PreserveSig]
    void GetDesc1(out D3D11_QUERY_DESC1 pDesc1);
}
