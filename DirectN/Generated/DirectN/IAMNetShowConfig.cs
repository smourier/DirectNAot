#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iamnetshowconfig
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fa2aa8f1-8b62-11d0-a520-000000000000")]
public partial interface IAMNetShowConfig : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_bufferingtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BufferingTime(ref double pBufferingTime);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_bufferingtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BufferingTime(double BufferingTime);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_usefixedudpport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UseFixedUDPPort(ref VARIANT_BOOL pUseFixedUDPPort);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_usefixedudpport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UseFixedUDPPort(VARIANT_BOOL UseFixedUDPPort);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_fixedudpport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FixedUDPPort(ref int pFixedUDPPort);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_fixedudpport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FixedUDPPort(int FixedUDPPort);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_usehttpproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UseHTTPProxy(ref VARIANT_BOOL pUseHTTPProxy);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_usehttpproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UseHTTPProxy(VARIANT_BOOL UseHTTPProxy);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_enableautoproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnableAutoProxy(ref VARIANT_BOOL pEnableAutoProxy);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_enableautoproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableAutoProxy(VARIANT_BOOL EnableAutoProxy);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_httpproxyhost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HTTPProxyHost(ref BSTR pbstrHTTPProxyHost);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_httpproxyhost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HTTPProxyHost(BSTR bstrHTTPProxyHost);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_httpproxyport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HTTPProxyPort(ref int pHTTPProxyPort);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_httpproxyport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HTTPProxyPort(int HTTPProxyPort);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_enablemulticast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnableMulticast(ref VARIANT_BOOL pEnableMulticast);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_enablemulticast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableMulticast(VARIANT_BOOL EnableMulticast);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_enableudp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnableUDP(ref VARIANT_BOOL pEnableUDP);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_enableudp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableUDP(VARIANT_BOOL EnableUDP);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_enabletcp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnableTCP(ref VARIANT_BOOL pEnableTCP);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_enabletcp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableTCP(VARIANT_BOOL EnableTCP);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-get_enablehttp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnableHTTP(ref VARIANT_BOOL pEnableHTTP);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowconfig-put_enablehttp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EnableHTTP(VARIANT_BOOL EnableHTTP);
}
