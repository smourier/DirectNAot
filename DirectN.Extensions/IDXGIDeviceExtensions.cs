namespace DirectN;

public static class IDXGIDeviceExtensions
{
    public static int GetGPUThreadPriority(this IComObject<IDXGIDevice> output) => GetGPUThreadPriority(output?.Object!);
    public static int GetGPUThreadPriority(this IDXGIDevice device)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.GetGPUThreadPriority(out var priority).ThrowOnError();
        return priority;
    }

    [SupportedOSPlatform("windows6.1")]
    public static uint GetMaximumFrameLatency(this IComObject<IDXGIDevice1> output) => GetMaximumFrameLatency(output?.Object!);
    public static uint GetMaximumFrameLatency(this IDXGIDevice1 device)
    {
        ArgumentNullException.ThrowIfNull(device);
        return device.GetMaximumFrameLatency();
    }

    public static IComObject<IDXGIAdapter> GetAdapter(this IComObject<IDXGIDevice> output) => GetAdapter(output?.Object!);
    public static IComObject<IDXGIAdapter> GetAdapter(this IDXGIDevice device)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.GetAdapter(out var adapter).ThrowOnError();
        return new ComObject<IDXGIAdapter>(adapter);
    }
}
