#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/ns-d3d11_2-d3d11_tiled_resource_coordinate
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TILED_RESOURCE_COORDINATE
{
    public uint X;
    public uint Y;
    public uint Z;
    public uint Subresource;
}
