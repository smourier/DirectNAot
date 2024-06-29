#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource3
[GeneratedComInterface, Guid("6b63d08e-4590-44af-9eb3-57ff1e73bf80")]
public partial interface IWMSInternalAdminNetSource3 : IWMSInternalAdminNetSource2
{
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetSourceCreator2(out nint ppNetSourceCreator);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource3-findproxyforurlex2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindProxyForURLEx2(BSTR bstrProtocol, BSTR bstrHost, BSTR bstrUrl, out BOOL pfProxyEnabled, out BSTR pbstrProxyServer, out uint pdwProxyPort, ref ulong pqwProxyContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterProxyFailure2(HRESULT hrParam, ulong qwProxyContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource3-shutdownproxycontext2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShutdownProxyContext2(ulong qwProxyContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUsingIE2(ulong qwProxyContext, out BOOL pfIsUsingIE);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource3-setcredentialsex2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCredentialsEx2(BSTR bstrRealm, BSTR bstrUrl, BOOL fProxy, BSTR bstrName, BSTR bstrPassword, BOOL fPersist, BOOL fConfirmedGood, BOOL fClearTextAuthentication);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource3-getcredentialsex2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredentialsEx2(BSTR bstrRealm, BSTR bstrUrl, BOOL fProxy, BOOL fClearTextAuthentication, out NETSOURCE_URLCREDPOLICY_SETTINGS pdwUrlPolicy, out BSTR pbstrName, out BSTR pbstrPassword, out BOOL pfConfirmedGood);
}
