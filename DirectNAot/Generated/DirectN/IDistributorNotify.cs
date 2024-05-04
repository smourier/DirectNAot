#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idistributornotify
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868af-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IDistributorNotify
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idistributornotify-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idistributornotify-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idistributornotify-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run(long tStart);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idistributornotify-setsyncsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncSource(IReferenceClock pClock);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idistributornotify-notifygraphchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyGraphChange();
}
