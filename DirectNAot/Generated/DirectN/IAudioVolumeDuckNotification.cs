namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiovolumeducknotification
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c3b284d4-6d39-4359-b3cf-b56ddb3bb39c")]
public partial interface IAudioVolumeDuckNotification
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiovolumeducknotification-onvolumeducknotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnVolumeDuckNotification(PWSTR sessionID, uint countCommunicationSessions);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiovolumeducknotification-onvolumeunducknotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnVolumeUnduckNotification(PWSTR sessionID);
}
