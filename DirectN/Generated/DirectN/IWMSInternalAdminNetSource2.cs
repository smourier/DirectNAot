#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource2
[GeneratedComInterface, Guid("e74d58c3-cf77-4b51-af17-744687c43eae")]
public partial interface IWMSInternalAdminNetSource2
{
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource2-setcredentialsex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCredentialsEx(BSTR bstrRealm, BSTR bstrUrl, BOOL fProxy, BSTR bstrName, BSTR bstrPassword, BOOL fPersist, BOOL fConfirmedGood);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource2-getcredentialsex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredentialsEx(BSTR bstrRealm, BSTR bstrUrl, BOOL fProxy, out NETSOURCE_URLCREDPOLICY_SETTINGS pdwUrlPolicy, out BSTR pbstrName, out BSTR pbstrPassword, out BOOL pfConfirmedGood);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource2-deletecredentialsex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteCredentialsEx(BSTR bstrRealm, BSTR bstrUrl, BOOL fProxy);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindProxyForURLEx(BSTR bstrProtocol, BSTR bstrHost, BSTR bstrUrl, out BOOL pfProxyEnabled, out BSTR pbstrProxyServer, out uint pdwProxyPort, ref uint pdwProxyContext);
}
