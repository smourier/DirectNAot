#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_view_instancing_flags
[Flags]
public enum D3D12_VIEW_INSTANCING_FLAGS
{
    D3D12_VIEW_INSTANCING_FLAG_NONE = 0,
    D3D12_VIEW_INSTANCING_FLAG_ENABLE_VIEW_INSTANCE_MASKING = 1,
}
