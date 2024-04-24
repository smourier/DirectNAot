namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10asynchronous
[GeneratedComInterface, Guid("9b7e4c0d-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Asynchronous : ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10asynchronous-begin
    [PreserveSig]
    void Begin();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10asynchronous-end
    [PreserveSig]
    void End();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10asynchronous-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(nint /* optional void* */ pData, uint DataSize, uint GetDataFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10asynchronous-getdatasize
    [PreserveSig]
    uint GetDataSize();
}
