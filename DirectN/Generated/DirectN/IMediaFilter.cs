#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imediafilter
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a86899-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaFilter : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediafilter-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediafilter-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediafilter-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run(long tStart);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediafilter-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(uint dwMilliSecsTimeout, out FILTER_STATE State);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediafilter-setsyncsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncSource(IReferenceClock? pClock);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediafilter-getsyncsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSyncSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IReferenceClock>))] out IReferenceClock pClock);
}
