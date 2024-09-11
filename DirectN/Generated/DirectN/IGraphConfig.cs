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
    HRESULT Reconnect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin pOutputPin, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin pInputPin, in AM_MEDIA_TYPE pmtFirstConnection, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pUsingFilter, HANDLE hAbortEvent, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-reconfigure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reconfigure([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphConfigCallback>))] IGraphConfigCallback pCallback, nint pvContext, uint dwFlags, HANDLE hAbortEvent);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-addfiltertocache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFilterToCache([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-enumcachefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumCacheFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumFilters>))] out IEnumFilters pEnum);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-removefilterfromcache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFilterFromCache([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-getstarttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartTime(out long prtStart);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-pushthroughdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushThroughData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin pOutputPin, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPinConnection>))] IPinConnection pConnection, HANDLE hEventAbort);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-setfilterflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFilterFlags([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pFilter, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-getfilterflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilterFlags([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pFilter, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfig-removefilterex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFilterEx([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBaseFilter>))] IBaseFilter pFilter, uint Flags);
}
