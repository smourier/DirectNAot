namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdm-session-type
public enum WMDM_SESSION_TYPE
{
    WMDM_SESSION_NONE = 0,
    WMDM_SESSION_TRANSFER_TO_DEVICE = 1,
    WMDM_SESSION_TRANSFER_FROM_DEVICE = 16,
    WMDM_SESSION_DELETE = 256,
    WMDM_SESSION_CUSTOM = 4096,
}
