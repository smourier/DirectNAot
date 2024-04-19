namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdmmessage
public enum WMDMMessage
{
    WMDM_MSG_DEVICE_ARRIVAL = 0,
    WMDM_MSG_DEVICE_REMOVAL = 1,
    WMDM_MSG_MEDIA_ARRIVAL = 2,
    WMDM_MSG_MEDIA_REMOVAL = 3,
}
