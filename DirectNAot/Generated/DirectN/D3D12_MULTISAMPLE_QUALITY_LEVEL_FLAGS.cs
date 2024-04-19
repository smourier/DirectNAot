namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_multisample_quality_level_flags
[Flags]
public enum D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS
{
    D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_NONE = 0,
    D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG_TILED_RESOURCE = 1,
}
