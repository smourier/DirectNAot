namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10counter
[GeneratedComInterface, Guid("9b7e4c11-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Counter : ID3D10Asynchronous
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10counter-getdesc
    [PreserveSig]
    public void GetDesc(out D3D10_COUNTER_DESC pDesc);
}
