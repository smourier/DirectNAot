#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambufferv2sourceevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("49c771f9-41b2-4cf7-9f9a-a313a8f6027e")]
public partial interface IMSVidStreamBufferV2SourceEvent : IMSVidFilePlaybackEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-ratingschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RatingsChanged();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-timehole
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TimeHole(int StreamOffsetMS, int SizeMS);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-staledataread
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StaleDataRead();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-contentbecomingstale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContentBecomingStale();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-stalefiledeleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StaleFileDeleted();
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-ratechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RateChange(double qwNewRate, double qwOldRate);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-broadcastevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BroadcastEvent(BSTR Guid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-broadcasteventex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BroadcastEventEx(BSTR Guid, uint Param1, uint Param2, uint Param3, uint Param4);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambufferv2sourceevent-contentprimarilyaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContentPrimarilyAudio();
}
