﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ibasefilter
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a86895-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IBaseFilter : IMediaFilter
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibasefilter-enumpins
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumPins(out IEnumPins ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibasefilter-findpin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindPin(PWSTR Id, out IPin ppPin);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibasefilter-queryfilterinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryFilterInfo(out FILTER_INFO pInfo);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibasefilter-joinfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT JoinFilterGraph(IFilterGraph? pGraph, PWSTR? pName);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ibasefilter-queryvendorinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryVendorInfo(out PWSTR pVendorInfo);
}