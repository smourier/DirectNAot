namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ipinconnection
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("4a9a62d3-27d4-403d-91e9-89f540e55534")]
public partial interface IPinConnection
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipinconnection-dynamicqueryaccept
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DynamicQueryAccept(in AM_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipinconnection-notifyendofstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyEndOfStream(HANDLE hNotifyEvent);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipinconnection-isendpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEndPin();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipinconnection-dynamicdisconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DynamicDisconnect();
}
