#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_root_descriptor1
public partial struct D3D12_ROOT_DESCRIPTOR1
{
    public uint ShaderRegister;
    public uint RegisterSpace;
    public D3D12_ROOT_DESCRIPTOR_FLAGS Flags;
}
