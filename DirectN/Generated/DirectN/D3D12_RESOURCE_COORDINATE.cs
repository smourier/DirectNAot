#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_resource_coordinate
public partial struct D3D12_RESOURCE_COORDINATE
{
    public ulong X;
    public uint Y;
    public uint Z;
    public uint SubresourceIndex;
}
