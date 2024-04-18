namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_status
public enum DIRECTMANIPULATION_STATUS
{
    DIRECTMANIPULATION_BUILDING = 0,
    DIRECTMANIPULATION_ENABLED = 1,
    DIRECTMANIPULATION_DISABLED = 2,
    DIRECTMANIPULATION_RUNNING = 3,
    DIRECTMANIPULATION_INERTIA = 4,
    DIRECTMANIPULATION_READY = 5,
    DIRECTMANIPULATION_SUSPENDED = 6,
}
