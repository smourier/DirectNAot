#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengine
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("98a1b0bb-03eb-4935-ae7c-93c1fa0e1c93")]
public partial interface IMFMediaEngine
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-geterror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetError([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaError>))] out IMFMediaError ppError);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-seterrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setsourceelements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceElements(IMFMediaEngineSrcElements pSrcElements);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSource(BSTR pUrl);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getcurrentsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentSource(out BSTR ppUrl);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getnetworkstate
    [PreserveSig]
    ushort GetNetworkState();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getpreload
    [PreserveSig]
    MF_MEDIA_ENGINE_PRELOAD GetPreload();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setpreload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getbuffered
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffered([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaTimeRange>))] out IMFMediaTimeRange ppBuffered);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-canplaytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanPlayType(BSTR type, out MF_MEDIA_ENGINE_CANPLAY pAnswer);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getreadystate
    [PreserveSig]
    ushort GetReadyState();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-isseeking
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsSeeking();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getcurrenttime
    [PreserveSig]
    double GetCurrentTime();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setcurrenttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentTime(double seekTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getstarttime
    [PreserveSig]
    double GetStartTime();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getduration
    [PreserveSig]
    double GetDuration();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-ispaused
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsPaused();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getdefaultplaybackrate
    [PreserveSig]
    double GetDefaultPlaybackRate();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setdefaultplaybackrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultPlaybackRate(double Rate);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getplaybackrate
    [PreserveSig]
    double GetPlaybackRate();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setplaybackrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPlaybackRate(double Rate);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getplayed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlayed([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaTimeRange>))] out IMFMediaTimeRange ppPlayed);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getseekable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSeekable([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaTimeRange>))] out IMFMediaTimeRange ppSeekable);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-isended
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsEnded();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getautoplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool GetAutoPlay();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setautoplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutoPlay([MarshalAs(UnmanagedType.U4)] bool AutoPlay);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getloop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool GetLoop();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setloop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLoop([MarshalAs(UnmanagedType.U4)] bool Loop);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-play
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Play();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getmuted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool GetMuted();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setmuted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMuted([MarshalAs(UnmanagedType.U4)] bool Muted);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getvolume
    [PreserveSig]
    double GetVolume();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-setvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVolume(double Volume);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-hasvideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool HasVideo();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-hasaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool HasAudio();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getnativevideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeVideoSize(nint /* optional uint* */ cx, nint /* optional uint* */ cy);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-getvideoaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoAspectRatio(nint /* optional uint* */ cx, nint /* optional uint* */ cy);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-transfervideoframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferVideoFrame(nint pDstSurf, nint /* optional MFVideoNormalizedRect* */ pSrc, in RECT pDst, nint /* optional MFARGB* */ pBorderClr);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengine-onvideostreamtick
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnVideoStreamTick(out long pPts);
}
