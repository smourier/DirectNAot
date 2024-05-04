#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_dred_flags
[Flags]
public enum D3D12_DRED_FLAGS
{
    D3D12_DRED_FLAG_NONE = 0,
    D3D12_DRED_FLAG_FORCE_ENABLE = 1,
    D3D12_DRED_FLAG_DISABLE_AUTOBREADCRUMBS = 2,
}
