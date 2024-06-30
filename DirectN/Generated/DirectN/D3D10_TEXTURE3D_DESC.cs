#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_texture3d_desc
public partial struct D3D10_TEXTURE3D_DESC
{
    public uint Width;
    public uint Height;
    public uint Depth;
    public uint MipLevels;
    public DXGI_FORMAT Format;
    public D3D10_USAGE Usage;
    public uint BindFlags;
    public uint CPUAccessFlags;
    public uint MiscFlags;
}
