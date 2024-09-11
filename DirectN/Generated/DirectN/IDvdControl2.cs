#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvdcontrol2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("33bc7430-eec0-11d2-8201-00a0c9d74842")]
public partial interface IDvdControl2
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playtitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayTitle(uint ulTitle, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playchapterintitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChapterInTitle(uint ulTitle, uint ulChapter, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playattimeintitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayAtTimeInTitle(uint ulTitle, in DVD_HMSF_TIMECODE pStartTime, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-returnfromsubmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReturnFromSubmenu(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playattime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayAtTime(in DVD_HMSF_TIMECODE pTime, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playchapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChapter(uint ulChapter, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playprevchapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayPrevChapter(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-replaychapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReplayChapter(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playnextchapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayNextChapter(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playforwards
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayForwards(double dSpeed, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playbackwards
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayBackwards(double dSpeed, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-showmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowMenu(DVD_MENU_ID MenuID, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectrelativebutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectRelativeButton(DVD_RELATIVE_BUTTON buttonDir);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-activatebutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateButton();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectbutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectButton(uint ulButton);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectandactivatebutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAndActivateButton(uint ulButton);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-stilloff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StillOff();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause(BOOL bState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectaudiostream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAudioStream(uint ulAudio, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectsubpicturestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectSubpictureStream(uint ulSubPicture, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-setsubpicturestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSubpictureState(BOOL bState, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAngle(uint ulAngle, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectparentallevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectParentalLevel(uint ulParentalLevel);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectparentalcountry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectParentalCountry(nint /* byte array */ bCountry);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectkaraokeaudiopresentationmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectKaraokeAudioPresentationMode(uint ulMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectvideomodepreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectVideoModePreference(uint ulPreferredDisplayMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-setdvddirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDVDDirectory(PWSTR pszwPath);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-activateatposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateAtPosition(POINT point);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectatposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAtPosition(POINT point);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playchaptersautostop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChaptersAutoStop(uint ulTitle, uint ulChapter, uint ulChaptersToPlay, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-acceptparentallevelchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcceptParentalLevelChange(BOOL bAccept);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-setoption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOption(DVD_OPTION_FLAG flag, BOOL fState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-setstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdState>))] IDvdState pState, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-playperiodintitleautostop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayPeriodInTitleAutoStop(uint ulTitle, in DVD_HMSF_TIMECODE pStartTime, in DVD_HMSF_TIMECODE pEndTime, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-setgprm
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGPRM(uint ulIndex, ushort wValue, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvdCmd>))] out IDvdCmd ppCmd);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectdefaultmenulanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectDefaultMenuLanguage(uint Language);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectdefaultaudiolanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectDefaultAudioLanguage(uint Language, DVD_AUDIO_LANG_EXT audioExtension);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol2-selectdefaultsubpicturelanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectDefaultSubpictureLanguage(uint Language, DVD_SUBPICTURE_LANG_EXT subpictureExtension);
}
