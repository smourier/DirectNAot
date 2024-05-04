#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_mapped_texture3d
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_MAPPED_TEXTURE3D
{
    public nint pData;
    public uint RowPitch;
    public uint DepthPitch;
}
