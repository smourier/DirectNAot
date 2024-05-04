#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_protected_resource_session_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_PROTECTED_RESOURCE_SESSION_DESC1
{
    public uint NodeMask;
    public D3D12_PROTECTED_RESOURCE_SESSION_FLAGS Flags;
    public Guid ProtectionType;
}
