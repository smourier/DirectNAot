namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11asynchronous
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b")]
public partial interface ID3D11Asynchronous : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11asynchronous-getdatasize
    [PreserveSig]
    public uint GetDataSize();
}
