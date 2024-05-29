namespace DirectN;

public static class ID3D12CommandQueueExtensions
{
    public static void ExecuteCommandLists(this IComObject<ID3D12CommandQueue> queue, IEnumerable<IComObject<ID3D12CommandList>> lists) => ExecuteCommandLists(queue?.Object!, lists.Unwrap()!);
    public static void ExecuteCommandLists(this ID3D12CommandQueue queue, IEnumerable<ID3D12CommandList> lists)
    {
        ArgumentNullException.ThrowIfNull(queue);
        ArgumentNullException.ThrowIfNull(lists);
        var list = lists.ToArray();
        if (list.Length == 0)
            return;

        queue.ExecuteCommandLists((uint)list.Length, list);
    }

    public static ulong GetTimestampFrequency(this IComObject<ID3D12CommandQueue> queue) => GetTimestampFrequency(queue.Object);
    public static ulong GetTimestampFrequency(this ID3D12CommandQueue queue)
    {
        ArgumentNullException.ThrowIfNull(queue);
        queue.GetTimestampFrequency(out var value).ThrowOnError();
        return value;
    }

    public static Tuple<ulong, ulong> GetClockCalibration(this IComObject<ID3D12CommandQueue> queue) => GetClockCalibration(queue.Object);
    public static Tuple<ulong, ulong> GetClockCalibration(this ID3D12CommandQueue queue)
    {
        ArgumentNullException.ThrowIfNull(queue);
        queue.GetClockCalibration(out var gpuValue, out var cpuValue).ThrowOnError();
        return new Tuple<ulong, ulong>(gpuValue, cpuValue);
    }

    public static D3D12_COMMAND_QUEUE_DESC GetDesc(this IComObject<ID3D12CommandQueue> queue) => GetDesc(queue.Object);
    public static D3D12_COMMAND_QUEUE_DESC GetDesc(this ID3D12CommandQueue queue)
    {
        ArgumentNullException.ThrowIfNull(queue);
        return queue.GetDesc();
    }

    public static void Signal(this IComObject<ID3D12CommandQueue> queue, IComObject<ID3D12Fence> fence, ulong value) => Signal(queue?.Object!, fence?.Object!, value);
    public static void Signal(this ID3D12CommandQueue queue, ID3D12Fence fence, ulong value)
    {
        ArgumentNullException.ThrowIfNull(queue);
        ArgumentNullException.ThrowIfNull(fence);
        queue.Signal(fence, value).ThrowOnError();
    }

    public static void Wait(this IComObject<ID3D12CommandQueue> queue, IComObject<ID3D12Fence> fence, ulong value) => Wait(queue?.Object!, fence?.Object!, value);
    public static void Wait(this ID3D12CommandQueue queue, ID3D12Fence fence, ulong value)
    {
        ArgumentNullException.ThrowIfNull(queue);
        ArgumentNullException.ThrowIfNull(fence);
        queue.Wait(fence, value).ThrowOnError();
    }
}
