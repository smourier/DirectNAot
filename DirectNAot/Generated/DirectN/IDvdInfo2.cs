namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvdinfo2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("34151510-eec0-11d2-8201-00a0c9d74842")]
public partial interface IDvdInfo2
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentdomain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentDomain(out DVD_DOMAIN pDomain);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentLocation(out DVD_PLAYBACK_LOCATION2 pLocation);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-gettotaltitletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalTitleTime(out DVD_HMSF_TIMECODE pTotalTime, out uint ulTimeCodeFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentbutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentButton(out uint pulButtonsAvailable, out uint pulCurrentButton);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentAngle(out uint pulAnglesAvailable, out uint pulCurrentAngle);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentAudio(out uint pulStreamsAvailable, out uint pulCurrentStream);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentsubpicture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentSubpicture(out uint pulStreamsAvailable, out uint pulCurrentStream, [MarshalAs(UnmanagedType.U4)] out bool pbIsDisabled);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentuops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentUOPS(out uint pulUOPs);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getallsprms
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllSPRMs(out nint pRegisterArray);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getallgprms
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllGPRMs(out nint pRegisterArray);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getaudiolanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioLanguage(uint ulStream, out uint pLanguage);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getsubpicturelanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubpictureLanguage(uint ulStream, out uint pLanguage);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-gettitleattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitleAttributes(uint ulTitle, out DVD_MenuAttributes pMenu, out DVD_TitleAttributes pTitle);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getvmgattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVMGAttributes(out DVD_MenuAttributes pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcurrentvideoattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentVideoAttributes(out DVD_VideoAttributes pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getaudioattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioAttributes(uint ulStream, out DVD_AudioAttributes pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getkaraokeattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKaraokeAttributes(uint ulStream, out DVD_KaraokeAttributes pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getsubpictureattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubpictureAttributes(uint ulStream, out DVD_SubpictureAttributes pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdvdvolumeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDVDVolumeInfo(out uint pulNumOfVolumes, out uint pulVolume, out DVD_DISC_SIDE pSide, out uint pulNumOfTitles);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdvdtextnumberoflanguages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDVDTextNumberOfLanguages(out uint pulNumOfLangs);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdvdtextlanguageinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDVDTextLanguageInfo(uint ulLangIndex, out uint pulNumOfStrings, out uint pLangCode, out DVD_TextCharSet pbCharacterSet);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdvdtextstringasnative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDVDTextStringAsNative(uint ulLangIndex, uint ulStringIndex, nint /* byte array */ pbBuffer, uint ulMaxBufferSize, out uint pulActualSize, out DVD_TextStringType pType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdvdtextstringasunicode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDVDTextStringAsUnicode(uint ulLangIndex, uint ulStringIndex, out PWSTR pchwBuffer, uint ulMaxBufferSize, out uint pulActualSize, out DVD_TextStringType pType);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getplayerparentallevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlayerParentalLevel(out uint pulParentalLevel, nint /* byte array */ pbCountryCode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getnumberofchapters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfChapters(uint ulTitle, out uint pulNumOfChapters);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-gettitleparentallevels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitleParentalLevels(uint ulTitle, out uint pulParentalLevels);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdvddirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDVDDirectory([MarshalUsing(CountElementName = nameof(ulMaxSize))] out PWSTR[] pszwPath, uint ulMaxSize, out uint pulActualSize);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-isaudiostreamenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAudioStreamEnabled(uint ulStreamNum, [MarshalAs(UnmanagedType.U4)] out bool pbEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdiscid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDiscID(PWSTR pszwPath, out ulong pullDiscID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(out IDvdState pStateData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getmenulanguages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMenuLanguages(out uint pLanguages, uint ulMaxLanguages, out uint pulActualLanguages);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getbuttonatposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetButtonAtPosition(POINT point, out uint pulButtonIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getcmdfromevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCmdFromEvent(nint lParam1, out IDvdCmd pCmdObj);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdefaultmenulanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultMenuLanguage(out uint pLanguage);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdefaultaudiolanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultAudioLanguage(out uint pLanguage, out DVD_AUDIO_LANG_EXT pAudioExtension);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdefaultsubpicturelanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultSubpictureLanguage(out uint pLanguage, out DVD_SUBPICTURE_LANG_EXT pSubpictureExtension);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getdecodercaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderCaps(out DVD_DECODER_CAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-getbuttonrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetButtonRect(uint ulButton, out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo2-issubpicturestreamenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSubpictureStreamEnabled(uint ulStreamNum, [MarshalAs(UnmanagedType.U4)] out bool pbEnabled);
}
