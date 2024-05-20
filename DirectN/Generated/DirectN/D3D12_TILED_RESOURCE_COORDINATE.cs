#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tiled_resource_coordinate
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TILED_RESOURCE_COORDINATE
{
    public uint X;
    public uint Y;
    public uint Z;
    public uint Subresource;
}
