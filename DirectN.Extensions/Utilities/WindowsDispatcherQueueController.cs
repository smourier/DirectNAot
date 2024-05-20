namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows10.0.16299.0")]
public partial class WindowsDispatcherQueueController
{
    private Windows.System.DispatcherQueueController? _controller;
    public Windows.System.DispatcherQueueController? Controller => _controller;

    public unsafe void EnsureOnCurrentThread()
    {
        if (Windows.System.DispatcherQueue.GetForCurrentThread() != null || _controller != null)
            return;

        var options = new DispatcherQueueOptions
        {
            dwSize = (uint)sizeof(DispatcherQueueOptions),
            threadType = DISPATCHERQUEUE_THREAD_TYPE.DQTYPE_THREAD_CURRENT,
            apartmentType = DISPATCHERQUEUE_THREAD_APARTMENTTYPE.DQTAT_COM_STA,
        };

        Functions.CreateDispatcherQueueController(options, out var controller).ThrowOnError();
        _controller = Windows.System.DispatcherQueueController.FromAbi(controller);
    }

    public Task ShutdownAsync()
    {
        var controller = Interlocked.Exchange(ref _controller, null);
        if (controller != null)
            return controller.ShutdownQueueAsync().AsTask();

        return Task.CompletedTask;
    }
}
