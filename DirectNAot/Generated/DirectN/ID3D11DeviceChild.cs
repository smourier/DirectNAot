namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11devicechild
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae")]
public partial interface ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicechild-getdevice
    [PreserveSig]
    public void GetDevice(out ID3D11Device ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicechild-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrivateData(in Guid guid, ref uint pDataSize, nint/* nint */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicechild-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateData(in Guid guid, uint DataSize, nint/* nint */ pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11devicechild-setprivatedatainterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateDataInterface(in Guid guid, nint pData);
}
