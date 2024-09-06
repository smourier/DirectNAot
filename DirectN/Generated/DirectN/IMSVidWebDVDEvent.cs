#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b4f7a674-9b83-49cb-a357-c63b871be958")]
public partial interface IMSVidWebDVDEvent : IMSVidPlaybackEvent
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DVDNotify(int lEventCode, VARIANT lParam1, VARIANT lParam2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayForwards(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayBackwards(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowMenu(DVDMenuIDConstants MenuID, VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectOrActivateButton(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StillOff(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PauseOn(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeCurrentAudioStream(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeCurrentSubpictureStream(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeCurrentAngle(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayAtTimeInTitle(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayAtTime(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChapterInTitle(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChapter(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReplayChapter(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayNextChapter(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReturnFromSubmenu(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayTitle(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayPrevChapter(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeKaraokePresMode(VARIANT_BOOL bEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeVideoPresMode(VARIANT_BOOL bEnabled);
}
