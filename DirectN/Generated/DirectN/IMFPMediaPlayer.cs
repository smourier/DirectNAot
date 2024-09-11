#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/nn-mfplay-imfpmediaplayer
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a714590a-58af-430a-85bf-44f5ec838d85")]
public partial interface IMFPMediaPlayer
{
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-play
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Play();
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-framestep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FrameStep();
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPosition(in Guid guidPositionType, in PROPVARIANT pvPositionValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPosition(in Guid guidPositionType, out PROPVARIANT pvPositionValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuration(in Guid guidPositionType, out PROPVARIANT pvDurationValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRate(float flRate);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRate(out float pflRate);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getsupportedrates
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedRates(BOOL fForwardDirection, out float pflSlowestRate, out float pflFastestRate);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(out MFP_MEDIAPLAYER_STATE peState);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-createmediaitemfromurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaItemFromURL(PWSTR pwszURL, BOOL fSync, nuint dwUserData, nint /* optional IMFPMediaItem* */ ppMediaItem);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-createmediaitemfromobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaItemFromObject(nint pIUnknownObj, BOOL fSync, nuint dwUserData, nint /* optional IMFPMediaItem* */ ppMediaItem);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setmediaitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPMediaItem>))] IMFPMediaItem pIMFPMediaItem);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-clearmediaitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearMediaItem();
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getmediaitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPMediaItem>))] out IMFPMediaItem ppIMFPMediaItem);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolume(out float pflVolume);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVolume(float flVolume);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getbalance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBalance(out float pflBalance);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setbalance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBalance(float flBalance);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMute(out BOOL pfMute);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMute(BOOL fMute);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getnativevideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeVideoSize(nint /* optional SIZE* */ pszVideo, nint /* optional SIZE* */ pszARVideo);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getidealvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIdealVideoSize(nint /* optional SIZE* */ pszMin, nint /* optional SIZE* */ pszMax);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setvideosourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoSourceRect(in MFVideoNormalizedRect pnrcSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getvideosourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoSourceRect(out MFVideoNormalizedRect pnrcSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAspectRatioMode(uint dwAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatioMode(out uint pdwAspectRatioMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getvideowindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoWindow(out HWND phwndVideo);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-updatevideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateVideo();
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-setbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderColor(COLORREF Clr);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-getbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBorderColor(out COLORREF pClr);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-inserteffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertEffect(nint pEffect, BOOL fOptional);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-removeeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEffect(nint pEffect);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-removealleffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllEffects();
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayer-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
