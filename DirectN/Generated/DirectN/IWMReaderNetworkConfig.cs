#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreadernetworkconfig
[GeneratedComInterface, Guid("96406bec-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMReaderNetworkConfig
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getbufferingtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferingTime(out ulong pcnsBufferingTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setbufferingtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferingTime(ulong cnsBufferingTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getudpportranges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUDPPortRanges([MarshalUsing(CountElementName = nameof(pcRanges))] out WM_PORT_NUMBER_RANGE[] pRangeArray, ref uint pcRanges);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setudpportranges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUDPPortRanges([In][MarshalUsing(CountElementName = nameof(cRanges))] WM_PORT_NUMBER_RANGE[] pRangeArray, uint cRanges);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getproxysettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProxySettings(PWSTR pwszProtocol, out WMT_PROXY_SETTINGS pProxySetting);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setproxysettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProxySettings(PWSTR pwszProtocol, WMT_PROXY_SETTINGS ProxySetting);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getproxyhostname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProxyHostName(PWSTR pwszProtocol, [MarshalUsing(CountElementName = nameof(pcchHostName))] out PWSTR pwszHostName, ref uint pcchHostName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setproxyhostname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProxyHostName(PWSTR pwszProtocol, PWSTR pwszHostName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getproxyport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProxyPort(PWSTR pwszProtocol, out uint pdwPort);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setproxyport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProxyPort(PWSTR pwszProtocol, uint dwPort);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getproxyexceptionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProxyExceptionList(PWSTR pwszProtocol, [MarshalUsing(CountElementName = nameof(pcchExceptionList))] out PWSTR pwszExceptionList, ref uint pcchExceptionList);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setproxyexceptionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProxyExceptionList(PWSTR pwszProtocol, PWSTR pwszExceptionList);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getproxybypassforlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProxyBypassForLocal(PWSTR pwszProtocol, out BOOL pfBypassForLocal);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setproxybypassforlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProxyBypassForLocal(PWSTR pwszProtocol, BOOL fBypassForLocal);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getforcererunautoproxydetection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetForceRerunAutoProxyDetection(out BOOL pfForceRerunDetection);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setforcererunautoproxydetection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetForceRerunAutoProxyDetection(BOOL fForceRerunDetection);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getenablemulticast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableMulticast(out BOOL pfEnableMulticast);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setenablemulticast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableMulticast(BOOL fEnableMulticast);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getenablehttp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableHTTP(out BOOL pfEnableHTTP);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setenablehttp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableHTTP(BOOL fEnableHTTP);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getenableudp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableUDP(out BOOL pfEnableUDP);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setenableudp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableUDP(BOOL fEnableUDP);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getenabletcp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnableTCP(out BOOL pfEnableTCP);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setenabletcp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnableTCP(BOOL fEnableTCP);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-resetprotocolrollover
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetProtocolRollover();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getconnectionbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConnectionBandwidth(out uint pdwConnectionBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-setconnectionbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConnectionBandwidth(uint dwConnectionBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getnumprotocolssupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumProtocolsSupported(out uint pcProtocols);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getsupportedprotocolname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedProtocolName(uint dwProtocolNum, [MarshalUsing(CountElementName = nameof(pcchProtocolName))] out PWSTR pwszProtocolName, ref uint pcchProtocolName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-addloggingurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddLoggingUrl(PWSTR pwszUrl);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getloggingurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLoggingUrl(uint dwIndex, [MarshalUsing(CountElementName = nameof(pcchUrl))] out PWSTR pwszUrl, ref uint pcchUrl);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-getloggingurlcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLoggingUrlCount(out uint pdwUrlCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadernetworkconfig-resetloggingurllist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetLoggingUrlList();
}
