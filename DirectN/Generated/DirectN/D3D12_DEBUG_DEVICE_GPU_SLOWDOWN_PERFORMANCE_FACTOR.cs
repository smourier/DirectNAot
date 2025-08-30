#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ns-d3d12sdklayers-d3d12_debug_device_gpu_slowdown_performance_factor
public partial struct D3D12_DEBUG_DEVICE_GPU_SLOWDOWN_PERFORMANCE_FACTOR : IValueGet<float>
{
    public float SlowdownFactor;
    
    readonly float IValueGet<float>.GetValue() => SlowdownFactor;
    readonly object? IValueGet.GetValue() => SlowdownFactor;
}
