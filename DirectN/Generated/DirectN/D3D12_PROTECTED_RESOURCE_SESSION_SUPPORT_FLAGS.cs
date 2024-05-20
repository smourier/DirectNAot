#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_protected_resource_session_support_flags
[Flags]
public enum D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS
{
    D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_NONE = 0,
    D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_SUPPORTED = 1,
}
