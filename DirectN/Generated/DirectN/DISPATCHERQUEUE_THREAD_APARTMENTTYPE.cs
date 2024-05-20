#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dispatcherqueue/ne-dispatcherqueue-dispatcherqueue_thread_apartmenttype
public enum DISPATCHERQUEUE_THREAD_APARTMENTTYPE
{
    DQTAT_COM_NONE = 0,
    DQTAT_COM_ASTA = 1,
    DQTAT_COM_STA = 2,
}
