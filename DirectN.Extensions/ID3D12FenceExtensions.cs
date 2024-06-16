namespace DirectN;

public static class ID3D12FenceExtensions
{
    public static ulong GetCompletedValue(this IComObject<ID3D12Fence> resource) => GetCompletedValue(resource?.Object!);
    public static ulong GetCompletedValue(this ID3D12Fence fence)
    {
        ArgumentNullException.ThrowIfNull(fence);
        return fence.GetCompletedValue();
    }

    public static void Signal(this IComObject<ID3D12Fence> fence, ulong value) => Signal(fence?.Object!, value);
    public static void Signal(this ID3D12Fence fence, ulong value)
    {
        ArgumentNullException.ThrowIfNull(fence);
        fence.Signal(value).ThrowOnError();
    }

    public static void SetEventOnCompletion(this IComObject<ID3D12Fence> fence, ulong value, HANDLE @event) => SetEventOnCompletion(fence?.Object!, value, @event);
    public static void SetEventOnCompletion(this ID3D12Fence fence, ulong value, HANDLE @event)
    {
        ArgumentNullException.ThrowIfNull(fence);
        fence.SetEventOnCompletion(value, @event).ThrowOnError();
    }
}
