namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nn-audioengineextensionapo-iaudioprocessingobjectnotifications2
[GeneratedComInterface, Guid("ca2cfbde-a9d6-4eb0-bc95-c4d026b380f0")]
public partial interface IAudioProcessingObjectNotifications2 : IAudioProcessingObjectNotifications
{
    // https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nf-audioengineextensionapo-iaudioprocessingobjectnotifications2-getaponotificationregistrationinfo2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApoNotificationRegistrationInfo2(APO_NOTIFICATION_TYPE maxApoNotificationTypeSupported, out APO_NOTIFICATION_DESCRIPTOR apoNotifications, out uint count);
}
