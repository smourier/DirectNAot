#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_subresource_data
public partial struct D3D10_SUBRESOURCE_DATA
{
    public nint pSysMem;
    public uint SysMemPitch;
    public uint SysMemSlicePitch;
}
