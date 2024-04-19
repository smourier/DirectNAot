namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_rldo_flags
[Flags]
public enum D3D12_RLDO_FLAGS
{
    D3D12_RLDO_NONE = 0,
    D3D12_RLDO_SUMMARY = 1,
    D3D12_RLDO_DETAIL = 2,
    D3D12_RLDO_IGNORE_INTERNAL = 4,
}
