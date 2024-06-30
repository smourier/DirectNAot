#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dispatcherqueue/ns-dispatcherqueue-dispatcherqueueoptions
public partial struct DispatcherQueueOptions
{
    public uint dwSize;
    public DISPATCHERQUEUE_THREAD_TYPE threadType;
    public DISPATCHERQUEUE_THREAD_APARTMENTTYPE apartmentType;
}
