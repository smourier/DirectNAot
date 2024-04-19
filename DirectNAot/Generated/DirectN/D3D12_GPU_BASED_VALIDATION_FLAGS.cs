namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_gpu_based_validation_flags
[Flags]
public enum D3D12_GPU_BASED_VALIDATION_FLAGS
{
    D3D12_GPU_BASED_VALIDATION_FLAGS_NONE = 0,
    D3D12_GPU_BASED_VALIDATION_FLAGS_DISABLE_STATE_TRACKING = 1,
}
