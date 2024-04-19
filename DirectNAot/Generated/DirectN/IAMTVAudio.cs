namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtvaudio
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("83ec1c30-23d1-11d1-99e6-00a0c9560266")]
public partial interface IAMTVAudio
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvaudio-gethardwaresupportedtvaudiomodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHardwareSupportedTVAudioModes(out int plModes);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvaudio-getavailabletvaudiomodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableTVAudioModes(out int plModes);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvaudio-get_tvaudiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TVAudioMode(out int plMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvaudio-put_tvaudiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TVAudioMode(int lMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvaudio-registernotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterNotificationCallBack(IAMTunerNotification pNotify, int lEvents);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvaudio-unregisternotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnRegisterNotificationCallBack(IAMTunerNotification pNotify);
}
