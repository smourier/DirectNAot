namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiobject
[GeneratedComInterface, Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
public partial interface IDXGIObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid Name, uint DataSize, in nint pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateDataInterface(in Guid Name, nint pUnknown);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(in Guid Name, ref uint pDataSize, out nint pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParent(in Guid riid, out nint ppParent);
}
