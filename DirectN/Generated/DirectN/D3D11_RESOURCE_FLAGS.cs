#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11on12/ns-d3d11on12-d3d11_resource_flags
public partial struct D3D11_RESOURCE_FLAGS
{
    public uint BindFlags;
    public uint MiscFlags;
    public uint CPUAccessFlags;
    public uint StructureByteStride;
}
