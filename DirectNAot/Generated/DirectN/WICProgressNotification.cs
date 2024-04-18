namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicprogressnotification
public enum WICProgressNotification
{
    WICProgressNotificationBegin = 65536,
    WICProgressNotificationEnd = 131072,
    WICProgressNotificationFrequent = 262144,
    WICProgressNotificationAll = -65536,
}
