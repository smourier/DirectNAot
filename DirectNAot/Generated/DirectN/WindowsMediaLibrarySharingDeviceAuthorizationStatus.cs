namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmlss/ne-wmlss-windowsmedialibrarysharingdeviceauthorizationstatus
public enum WindowsMediaLibrarySharingDeviceAuthorizationStatus
{
    DEVICE_AUTHORIZATION_UNKNOWN = 0,
    DEVICE_AUTHORIZATION_ALLOWED = 1,
    DEVICE_AUTHORIZATION_DENIED = 2,
}
