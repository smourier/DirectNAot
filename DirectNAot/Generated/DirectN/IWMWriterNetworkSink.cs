#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriternetworksink
[GeneratedComInterface, Guid("96406be7-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMWriterNetworkSink : IWMWriterSink
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-setmaximumclients
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaximumClients(uint dwMaxClients);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-getmaximumclients
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaximumClients(out uint pdwMaxClients);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-setnetworkprotocol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNetworkProtocol(WMT_NET_PROTOCOL protocol);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-getnetworkprotocol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetworkProtocol(out WMT_NET_PROTOCOL pProtocol);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-gethosturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHostURL(out PWSTR pwszURL, ref uint pcchURL);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(ref uint pdwPortNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriternetworksink-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
