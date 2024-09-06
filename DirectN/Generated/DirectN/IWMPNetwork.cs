#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpnetwork
[GeneratedComInterface, Guid("ec21b779-edef-462d-bba4-ad9dde2b29a7")]
public partial interface IWMPNetwork : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_bandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_bandWidth(ref int plBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_recoveredpackets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_recoveredPackets(ref int plRecoveredPackets);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_sourceprotocol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_sourceProtocol(ref BSTR pbstrSourceProtocol);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_receivedpackets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_receivedPackets(ref int plReceivedPackets);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_lostpackets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_lostPackets(ref int plLostPackets);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_receptionquality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_receptionQuality(ref int plReceptionQuality);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_bufferingcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_bufferingCount(ref int plBufferingCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_bufferingprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_bufferingProgress(ref int plBufferingProgress);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_bufferingtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_bufferingTime(ref int plBufferingTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-put_bufferingtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_bufferingTime(int lBufferingTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_framerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_frameRate(ref int plFrameRate);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_maxbitrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_maxBitRate(ref int plBitRate);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_bitrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_bitRate(ref int plBitRate);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-getproxysettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getProxySettings(BSTR bstrProtocol, ref int plProxySetting);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-setproxysettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setProxySettings(BSTR bstrProtocol, int lProxySetting);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-getproxyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getProxyName(BSTR bstrProtocol, ref BSTR pbstrProxyName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-setproxyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setProxyName(BSTR bstrProtocol, BSTR bstrProxyName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-getproxyport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getProxyPort(BSTR bstrProtocol, ref int lProxyPort);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-setproxyport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setProxyPort(BSTR bstrProtocol, int lProxyPort);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-getproxyexceptionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getProxyExceptionList(BSTR bstrProtocol, ref BSTR pbstrExceptionList);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-setproxyexceptionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setProxyExceptionList(BSTR bstrProtocol, BSTR pbstrExceptionList);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-getproxybypassforlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getProxyBypassForLocal(BSTR bstrProtocol, ref VARIANT_BOOL pfBypassForLocal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-setproxybypassforlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setProxyBypassForLocal(BSTR bstrProtocol, VARIANT_BOOL fBypassForLocal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_maxbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_maxBandwidth(ref int lMaxBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-put_maxbandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_maxBandwidth(int lMaxBandwidth);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_downloadprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_downloadProgress(ref int plDownloadProgress);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_encodedframerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_encodedFrameRate(ref int plFrameRate);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpnetwork-get_framesskipped
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_framesSkipped(ref int plFrames);
}
