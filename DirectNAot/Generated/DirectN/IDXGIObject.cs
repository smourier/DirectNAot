namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiobject
[GeneratedComInterface, Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
public partial interface IDXGIObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(Guid Name, uint DataSize, nint pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateDataInterface(Guid Name, nint pUnknown);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(Guid Name, out uint pDataSize, out nint pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParent(Guid riid, out nint ppParent);
}
