namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtextnotify
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("df6b87b6-ce12-45db-aba7-432fe054e57d")]
public partial interface IMFTimedTextNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextnotify-trackadded
    [PreserveSig]
    void TrackAdded(uint trackId);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextnotify-trackremoved
    [PreserveSig]
    void TrackRemoved(uint trackId);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextnotify-trackselected
    [PreserveSig]
    void TrackSelected(uint trackId, [MarshalAs(UnmanagedType.U4)] bool selected);
    
    [PreserveSig]
    void TrackReadyStateChanged(uint trackId);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextnotify-error
    [PreserveSig]
    void Error(MF_TIMED_TEXT_ERROR_CODE errorCode, HRESULT extendedErrorCode, uint sourceTrackId);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextnotify-cue
    [PreserveSig]
    void Cue(MF_TIMED_TEXT_CUE_EVENT cueEvent, double currentTime, IMFTimedTextCue? cue);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextnotify-reset
    [PreserveSig]
    void Reset();
}
