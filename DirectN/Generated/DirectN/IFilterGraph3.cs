#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifiltergraph3
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("aaf38154-b80b-422f-91e6-b66467509a07")]
public partial interface IFilterGraph3 : IFilterGraph2
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifiltergraph3-setsyncsourceex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncSourceEx(IReferenceClock pClockForMostOfFilterGraph, IReferenceClock pClockForFilter, IBaseFilter pFilter);
}
