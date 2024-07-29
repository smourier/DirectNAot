#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("cf45f88b-ac56-4ee2-a73a-ed04e2885d3c")]
public partial interface IMSVidWebDVD : IMSVidPlayback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDVDEvent(int lEvent, nint lParam1, nint lParam2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayTitle(int lTitle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChapterInTitle(int lTitle, int lChapter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChapter(int lChapter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayChaptersAutoStop(int lTitle, int lstrChapter, int lChapterCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayAtTime(BSTR strTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayAtTimeInTitle(int lTitle, BSTR strTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayPeriodInTitleAutoStop(int lTitle, BSTR strStartTime, BSTR strEndTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReplayChapter();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayPrevChapter();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayNextChapter();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StillOff();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioLanguage(int lStream, VARIANT_BOOL fFormat, out BSTR strAudioLang);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowMenu(DVDMenuIDConstants MenuID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReturnFromSubmenu();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ButtonsAvailable(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentButton(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAndActivateButton(int lButton);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateButton();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectRightButton();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectLeftButton();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectLowerButton();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectUpperButton();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateAtPosition(int xPos, int yPos);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectAtPosition(int xPos, int yPos);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ButtonAtPosition(int xPos, int yPos, out int plButton);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfChapters(int lTitle, out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TotalTitleTime(out BSTR pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TitlesAvailable(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VolumesAvailable(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentVolume(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentDiscSide(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentDomain(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentChapter(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentTitle(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentTime(out BSTR pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DVDTimeCode2bstr(int timeCode, out BSTR pTimeStr);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDDirectory(out BSTR pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DVDDirectory(BSTR newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSubpictureStreamEnabled(int lstream, out VARIANT_BOOL fEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAudioStreamEnabled(int lstream, out VARIANT_BOOL fEnabled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentSubpictureStream(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CurrentSubpictureStream(int newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SubpictureLanguage(int lStream, out BSTR strLanguage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentAudioStream(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CurrentAudioStream(int newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioStreamsAvailable(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AnglesAvailable(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentAngle(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CurrentAngle(int newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SubpictureStreamsAvailable(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SubpictureOn(out VARIANT_BOOL pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SubpictureOn(VARIANT_BOOL newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDUniqueID(out BSTR pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcceptParentalLevelChange(VARIANT_BOOL fAccept, BSTR strUserName, BSTR strPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyParentalLevelChange(VARIANT_BOOL newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectParentalCountry(int lCountry, BSTR strUserName, BSTR strPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectParentalLevel(int lParentalLevel, BSTR strUserName, BSTR strPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TitleParentalLevels(int lTitle, out int plParentalLevels);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PlayerParentalCountry(out int plCountryCode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PlayerParentalLevel(out int plParentalLevel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Eject();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UOPValid(int lUOP, out VARIANT_BOOL pfValid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SPRM(int lIndex, out short psSPRM);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GPRM(int lIndex, out short psSPRM);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_GPRM(int lIndex, short sValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDTextStringType(int lLangIndex, int lStringIndex, out DVDTextStringType pType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDTextString(int lLangIndex, int lStringIndex, out BSTR pstrText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDTextNumberOfStrings(int lLangIndex, out int plNumOfStrings);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDTextNumberOfLanguages(out int plNumOfLangs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDTextLanguageLCID(int lLangIndex, out int lcid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegionChange();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDAdm([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteBookmark();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreBookmark();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveBookmark();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectDefaultAudioLanguage(int lang, int ext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectDefaultSubpictureLanguage(int lang, DVDSPExt ext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PreferredSubpictureStream(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultMenuLanguage(out int lang);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultMenuLanguage(int lang);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultSubpictureLanguage(out int lang);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultAudioLanguage(out int lang);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultSubpictureLanguageExt(out DVDSPExt ext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultAudioLanguageExt(out int ext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LanguageFromLCID(int lcid, out BSTR lang);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KaraokeAudioPresentationMode(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_KaraokeAudioPresentationMode(int newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KaraokeChannelContent(int lStream, int lChan, out int lContent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KaraokeChannelAssignment(int lStream, out int lChannelAssignment);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestorePreferredSettings();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ButtonRect(int lButton, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidRect>))] out IMSVidRect pRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DVDScreenInMouseCoordinates([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidRect>))] out IMSVidRect ppRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DVDScreenInMouseCoordinates(IMSVidRect pRect);
}
