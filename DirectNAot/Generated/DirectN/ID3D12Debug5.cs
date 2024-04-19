namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debug5
[GeneratedComInterface, Guid("548d6b12-09fa-40e0-9069-5dcd589a52c9")]
public partial interface ID3D12Debug5 : ID3D12Debug4
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug5-setenableautoname
    [PreserveSig]
    void SetEnableAutoName([MarshalAs(UnmanagedType.U4)] bool Enable);
}
