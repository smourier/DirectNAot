﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtext
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("1f2a94c9-a3df-430d-9d0f-acd85ddc29af")]
public partial interface IMFTimedText
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-registernotifications
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterNotifications(IMFTimedTextNotify? notify);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-selecttrack
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectTrack(uint trackId, [MarshalAs(UnmanagedType.U4)] bool selected);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-adddatasource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDataSource(IMFByteStream byteStream, PWSTR? label, PWSTR? language, MF_TIMED_TEXT_TRACK_KIND kind, [MarshalAs(UnmanagedType.U4)] bool isDefault, out uint trackId);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-adddatasourcefromurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDataSourceFromUrl(PWSTR url, PWSTR? label, PWSTR? language, MF_TIMED_TEXT_TRACK_KIND kind, [MarshalAs(UnmanagedType.U4)] bool isDefault, out uint trackId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTrack(PWSTR? label, PWSTR? language, MF_TIMED_TEXT_TRACK_KIND kind, out IMFTimedTextTrack track);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-removetrack
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveTrack(IMFTimedTextTrack track);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-getcuetimeoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueTimeOffset(out double offset);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-setcuetimeoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCueTimeOffset(double offset);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-gettracks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTracks(out IMFTimedTextTrackList tracks);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-getactivetracks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActiveTracks(out IMFTimedTextTrackList activeTracks);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-gettexttracks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextTracks(out IMFTimedTextTrackList textTracks);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-getmetadatatracks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataTracks(out IMFTimedTextTrackList metadataTracks);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-setinbandenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInBandEnabled([MarshalAs(UnmanagedType.U4)] bool enabled);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtext-isinbandenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsInBandEnabled();
}
