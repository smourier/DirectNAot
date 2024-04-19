namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nn-audioengineextensionapo-iaudioprocessingobjectnotifications
[GeneratedComInterface, Guid("56b0c76f-02fd-4b21-a52e-9f8219fc86e4")]
public partial interface IAudioProcessingObjectNotifications
{
    // https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nf-audioengineextensionapo-iaudioprocessingobjectnotifications-getaponotificationregistrationinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApoNotificationRegistrationInfo(out APO_NOTIFICATION_DESCRIPTOR apoNotifications, out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nf-audioengineextensionapo-iaudioprocessingobjectnotifications-handlenotification
    [PreserveSig]
    void HandleNotification(in APO_NOTIFICATION apoNotification);
}
