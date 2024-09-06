#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e9707e05-6d55-4636-b185-3de21210bd75")]
public partial interface IMFMediaKeySession2 : IMFMediaKeySession
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeyStatuses(out nint pKeyStatusesArray, out uint puSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(BSTR bstrSessionId, out BOOL pfLoaded);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateRequest(BSTR initDataType, nint /* byte array */ pbInitData, uint cb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Expiration(out double dblExpiration);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
