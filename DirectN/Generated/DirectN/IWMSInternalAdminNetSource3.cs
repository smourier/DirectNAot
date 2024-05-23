#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource3
[GeneratedComInterface, Guid("6b63d08e-4590-44af-9eb3-57ff1e73bf80")]
public partial interface IWMSInternalAdminNetSource3 : IWMSInternalAdminNetSource2
{
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetSourceCreator2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppNetSourceCreator);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource3-findproxyforurlex2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindProxyForURLEx2(BSTR bstrProtocol, BSTR bstrHost, BSTR bstrUrl, [MarshalAs(UnmanagedType.U4)] out bool pfProxyEnabled, out BSTR pbstrProxyServer, out uint pdwProxyPort, ref ulong pqwProxyContext);
    
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
    HRESULT IsUsingIE2(ulong qwProxyContext, [MarshalAs(UnmanagedType.U4)] out bool pfIsUsingIE);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource3-setcredentialsex2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCredentialsEx2(BSTR bstrRealm, BSTR bstrUrl, [MarshalAs(UnmanagedType.U4)] bool fProxy, BSTR bstrName, BSTR bstrPassword, [MarshalAs(UnmanagedType.U4)] bool fPersist, [MarshalAs(UnmanagedType.U4)] bool fConfirmedGood, [MarshalAs(UnmanagedType.U4)] bool fClearTextAuthentication);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource3-getcredentialsex2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredentialsEx2(BSTR bstrRealm, BSTR bstrUrl, [MarshalAs(UnmanagedType.U4)] bool fProxy, [MarshalAs(UnmanagedType.U4)] bool fClearTextAuthentication, out NETSOURCE_URLCREDPOLICY_SETTINGS pdwUrlPolicy, out BSTR pbstrName, out BSTR pbstrPassword, [MarshalAs(UnmanagedType.U4)] out bool pfConfirmedGood);
}
