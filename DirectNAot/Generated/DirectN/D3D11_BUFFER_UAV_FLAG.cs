#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_buffer_uav_flag
public enum D3D11_BUFFER_UAV_FLAG
{
    D3D11_BUFFER_UAV_FLAG_RAW = 1,
    D3D11_BUFFER_UAV_FLAG_APPEND = 2,
    D3D11_BUFFER_UAV_FLAG_COUNTER = 4,
}
