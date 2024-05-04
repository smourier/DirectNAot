#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ne-mfapi-mfasync_workqueue_type
public enum MFASYNC_WORKQUEUE_TYPE
{
    MF_STANDARD_WORKQUEUE = 0,
    MF_WINDOW_WORKQUEUE = 1,
    MF_MULTITHREADED_WORKQUEUE = 2,
}
