#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifiltergraph
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a8689f-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IFilterGraph
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-addfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFilter(IBaseFilter pFilter, PWSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-removefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFilter(IBaseFilter pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-enumfilters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumFilters(out IEnumFilters ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-findfilterbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFilterByName(PWSTR pName, out IBaseFilter ppFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-connectdirect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectDirect(IPin ppinOut, IPin ppinIn, nint /* optional AM_MEDIA_TYPE* */ pmt);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-reconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reconnect(IPin ppin);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect(IPin ppin);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph-setdefaultsyncsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultSyncSource();
}
