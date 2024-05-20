#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-igraphconfig
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("03a1eb8e-32bf-4245-8502-114d08a9cb88")]
public partial interface IGraphConfig
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-reconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reconnect(IPin pOutputPin, IPin pInputPin, in AM_MEDIA_TYPE pmtFirstConnection, IBaseFilter pUsingFilter, HANDLE hAbortEvent, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-reconfigure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reconfigure(IGraphConfigCallback pCallback, nint pvContext, uint dwFlags, HANDLE hAbortEvent);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-addfiltertocache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFilterToCache(IBaseFilter pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-enumcachefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumCacheFilter(out IEnumFilters pEnum);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-removefilterfromcache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFilterFromCache(IBaseFilter pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-getstarttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartTime(out long prtStart);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-pushthroughdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushThroughData(IPin pOutputPin, IPinConnection pConnection, HANDLE hEventAbort);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-setfilterflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFilterFlags(IBaseFilter pFilter, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-getfilterflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilterFlags(IBaseFilter pFilter, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-removefilterex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFilterEx(IBaseFilter pFilter, uint Flags);
}
