#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtuner
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("211a8761-03ac-11d1-8d13-00aa00bd8339")]
public partial interface IAMTuner
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-put_channel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Channel(int lChannel, int lVideoSubChannel, int lAudioSubChannel);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-get_channel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Channel(out int plChannel, out int plVideoSubChannel, out int plAudioSubChannel);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-channelminmax
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChannelMinMax(out int lChannelMin, out int lChannelMax);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-put_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CountryCode(int lCountryCode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-get_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountryCode(out int plCountryCode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-put_tuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TuningSpace(int lTuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-get_tuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TuningSpace(out int plTuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-logon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Logon(HANDLE hCurrentUser);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-logout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Logout();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-signalpresent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SignalPresent(out int plSignalStrength);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-put_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Mode(AMTunerModeType lMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-get_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Mode(out AMTunerModeType plMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-getavailablemodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableModes(out int plModes);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-registernotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterNotificationCallBack(IAMTunerNotification pNotify, int lEvents);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtuner-unregisternotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnRegisterNotificationCallBack(IAMTunerNotification pNotify);
}
