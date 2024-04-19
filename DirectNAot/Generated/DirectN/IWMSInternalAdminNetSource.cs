namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource
[GeneratedComInterface, Guid("8bb23e5f-d127-4afb-8d02-ae5b66d54c78")]
public partial interface IWMSInternalAdminNetSource
{
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint pSharedNamespace, nint pNamespaceNode, INSNetSourceCreator pNetSourceCreator, [MarshalAs(UnmanagedType.U4)] bool fEmbeddedInServer);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetSourceCreator(out INSNetSourceCreator ppNetSourceCreator);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-setcredentials
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCredentials(BSTR bstrRealm, BSTR bstrName, BSTR bstrPassword, [MarshalAs(UnmanagedType.U4)] bool fPersist, [MarshalAs(UnmanagedType.U4)] bool fConfirmedGood);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-getcredentials
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredentials(BSTR bstrRealm, out BSTR pbstrName, out BSTR pbstrPassword, [MarshalAs(UnmanagedType.U4)] out bool pfConfirmedGood);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-deletecredentials
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteCredentials(BSTR bstrRealm);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-getcredentialflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCredentialFlags(out uint lpdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-setcredentialflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCredentialFlags(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-findproxyforurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindProxyForURL(BSTR bstrProtocol, BSTR bstrHost, [MarshalAs(UnmanagedType.U4)] out bool pfProxyEnabled, out BSTR pbstrProxyServer, out uint pdwProxyPort, ref uint pdwProxyContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-registerproxyfailure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterProxyFailure(HRESULT hrParam, uint dwProxyContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nf-wmsinternaladminnetsource-iwmsinternaladminnetsource-shutdownproxycontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShutdownProxyContext(uint dwProxyContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsinternaladminnetsource/nn-wmsinternaladminnetsource-iwmsinternaladminnetsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUsingIE(uint dwProxyContext, [MarshalAs(UnmanagedType.U4)] out bool pfIsUsingIE);
}
