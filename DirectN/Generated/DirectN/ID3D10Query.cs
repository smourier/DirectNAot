#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10query
[GeneratedComInterface, Guid("9b7e4c0e-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Query : ID3D10Asynchronous
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10query-getdesc
    [PreserveSig]
    void GetDesc(out D3D10_QUERY_DESC pDesc);
}
