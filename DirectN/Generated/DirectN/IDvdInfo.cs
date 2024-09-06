#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvdinfo
[GeneratedComInterface, Guid("a70efe60-e2a3-11d0-a9be-00aa0061be93")]
public partial interface IDvdInfo
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentdomain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentDomain(out DVD_DOMAIN pDomain);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentLocation(out DVD_PLAYBACK_LOCATION pLocation);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-gettotaltitletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalTitleTime(out uint pulTotalTime);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentbutton
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentButton(out uint pulButtonsAvailable, out uint pulCurrentButton);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentAngle(out uint pulAnglesAvailable, out uint pulCurrentAngle);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentAudio(out uint pulStreamsAvailable, out uint pulCurrentStream);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentsubpicture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentSubpicture(out uint pulStreamsAvailable, out uint pulCurrentStream, out BOOL pIsDisabled);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentuops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentUOPS(out uint pUOP);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getallsprms
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllSPRMs(out nint pRegisterArray);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getallgprms
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllGPRMs(out nint pRegisterArray);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getaudiolanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioLanguage(uint ulStream, out uint pLanguage);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getsubpicturelanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubpictureLanguage(uint ulStream, out uint pLanguage);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-gettitleattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitleAttributes(uint ulTitle, out DVD_ATR pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getvmgattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVMGAttributes(out DVD_ATR pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentvideoattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentVideoAttributes(out nint /* byte array */ pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentaudioattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentAudioAttributes(out nint /* byte array */ pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentsubpictureattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentSubpictureAttributes(out nint /* byte array */ pATR);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getcurrentvolumeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentVolumeInfo(out uint pulNumOfVol, out uint pulThisVolNum, out DVD_DISC_SIDE pSide, out uint pulNumOfTitles);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getdvdtextinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDVDTextInfo(nint /* byte array */ pTextManager, uint ulBufSize, out uint pulActualSize);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getplayerparentallevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlayerParentalLevel(out uint pulParentalLevel, out uint pulCountryCode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getnumberofchapters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfChapters(uint ulTitle, out uint pulNumberOfChapters);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-gettitleparentallevels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitleParentalLevels(uint ulTitle, out uint pulParentalLevels);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdinfo-getroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRoot([MarshalUsing(CountElementName = nameof(ulBufSize))] PSTR pRoot, uint ulBufSize, out uint pulActualSize);
}
