namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ifilterchain
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("dcfbdcf6-0dc2-45f5-9ab2-7c330ea09c29")]
public partial interface IFilterChain
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilterchain-startchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilterchain-pausechain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PauseChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilterchain-stopchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ifilterchain-removechain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveChain(IBaseFilter pStartFilter, IBaseFilter pEndFilter);
}
