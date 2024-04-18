namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_4/nn-d3d11_4-id3d11device4
[GeneratedComInterface, Guid("8992ab71-02e6-4b8d-ba48-b056dcda42c4")]
public partial interface ID3D11Device4 : ID3D11Device3
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11device4-registerdeviceremovedevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterDeviceRemovedEvent(HANDLE hEvent, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11device4-unregisterdeviceremoved
    [PreserveSig]
    public void UnregisterDeviceRemoved(uint dwCookie);
}
