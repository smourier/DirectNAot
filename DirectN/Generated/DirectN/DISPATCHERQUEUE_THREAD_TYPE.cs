#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dispatcherqueue/ne-dispatcherqueue-dispatcherqueue_thread_type
public enum DISPATCHERQUEUE_THREAD_TYPE
{
    DQTYPE_THREAD_DEDICATED = 1,
    DQTYPE_THREAD_CURRENT = 2,
}
