#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_buffer_uav_flags
[Flags]
public enum D3D12_BUFFER_UAV_FLAGS
{
    D3D12_BUFFER_UAV_FLAG_NONE = 0,
    D3D12_BUFFER_UAV_FLAG_RAW = 1,
}
