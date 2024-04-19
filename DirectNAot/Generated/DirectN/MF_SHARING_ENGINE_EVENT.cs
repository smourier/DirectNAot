namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/ne-mfsharingengine-mf_sharing_engine_event
public enum MF_SHARING_ENGINE_EVENT
{
    MF_SHARING_ENGINE_EVENT_DISCONNECT = 2000,
    MF_SHARING_ENGINE_EVENT_LOCALRENDERINGSTARTED = 2001,
    MF_SHARING_ENGINE_EVENT_LOCALRENDERINGENDED = 2002,
    MF_SHARING_ENGINE_EVENT_STOPPED = 2003,
    MF_SHARING_ENGINE_EVENT_ERROR = 2501,
}
