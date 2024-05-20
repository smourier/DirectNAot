#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvdcontrol
[GeneratedComInterface, Guid("a70efe61-e2a3-11d0-a9be-00aa0061be93")]
public partial interface IDvdControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-titleplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TitlePlay(uint ulTitle);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-chapterplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChapterPlay(uint ulTitle, uint ulChapter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-timeplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TimePlay(uint ulTitle, uint bcdTime);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-stopforresume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopForResume();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-goup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoUp();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-timesearch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TimeSearch(uint bcdTime);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-chaptersearch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChapterSearch(uint ulChapter);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-prevpgsearch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrevPGSearch();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-toppgsearch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TopPGSearch();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-nextpgsearch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NextPGSearch();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-forwardscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ForwardScan(double dwSpeed);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-backwardscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BackwardScan(double dwSpeed);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-menucall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MenuCall(DVD_MENU_ID MenuID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-upperbuttonselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpperButtonSelect();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-lowerbuttonselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LowerButtonSelect();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-leftbuttonselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LeftButtonSelect();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-rightbuttonselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RightButtonSelect();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-buttonactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ButtonActivate();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-buttonselectandactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ButtonSelectAndActivate(uint ulButton);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-stilloff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StillOff();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-pauseon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PauseOn();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-pauseoff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PauseOff();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-menulanguageselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MenuLanguageSelect(uint Language);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-audiostreamchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AudioStreamChange(uint ulAudio);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-subpicturestreamchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SubpictureStreamChange(uint ulSubPicture, [MarshalAs(UnmanagedType.U4)] bool bDisplay);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-anglechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AngleChange(uint ulAngle);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-parentallevelselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParentalLevelSelect(uint ulParentalLevel);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-parentalcountryselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParentalCountrySelect(ushort wCountry);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-karaokeaudiopresentationmodechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KaraokeAudioPresentationModeChange(uint ulMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-videomodepreferrence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VideoModePreferrence(uint ulPreferredDisplayMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-setroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRoot(PWSTR pszPath);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-mouseactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MouseActivate(POINT point);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-mouseselect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MouseSelect(POINT point);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcontrol-chapterplayautostop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChapterPlayAutoStop(uint ulTitle, uint ulChapter, uint ulChaptersToPlay);
}
