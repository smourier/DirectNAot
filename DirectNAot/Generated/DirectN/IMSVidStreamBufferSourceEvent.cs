namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersourceevent
[GeneratedComInterface, Guid("50ce8a7d-9c28-4da8-9042-cdfa7116f979")]
public partial interface IMSVidStreamBufferSourceEvent : IMSVidFilePlaybackEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-certificatefailure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CertificateFailure();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-certificatesuccess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CertificateSuccess();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-ratingsblocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RatingsBlocked();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-ratingsunblocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RatingsUnblocked();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-ratingschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RatingsChanged();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-timehole
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TimeHole(int StreamOffsetMS, int SizeMS);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-staledataread
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StaleDataRead();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-contentbecomingstale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContentBecomingStale();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent-stalefiledeleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StaleFileDeleted();
}
