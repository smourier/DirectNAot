namespace DirectNAot.Extensions.Utilities
{
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
                dwSize = sizeof(DispatcherQueueOptions),
                threadType = DQTYPE_THREAD_CURRENT,
                apartmentType = DQTAT_COM_STA
            };

            var hr = CreateDispatcherQueueController(options, out var controller);
            if (hr != 0)
                Marshal.ThrowExceptionForHR(hr);

            _controller = Windows.System.DispatcherQueueController.FromAbi(controller);
        }

        public Task ShutdownAsync()
        {
            var controller = Interlocked.Exchange(ref _controller, null);
            if (controller != null)
                return controller.ShutdownQueueAsync().AsTask();

            return Task.CompletedTask;
        }

        private const int DQTYPE_THREAD_CURRENT = 2;
        private const int DQTAT_COM_STA = 2;

        [StructLayout(LayoutKind.Sequential)]
        private struct DispatcherQueueOptions
        {
            public int dwSize;
            public int threadType;
            public int apartmentType;
        }

        [LibraryImport("coreMessaging")]
        private static partial int CreateDispatcherQueueController(DispatcherQueueOptions options, out nint controller);
    }
}
