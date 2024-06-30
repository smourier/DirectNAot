#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1/ns-d3d10_1-d3d10_texcube_array_srv1
public partial struct D3D10_TEXCUBE_ARRAY_SRV1
{
    public uint MostDetailedMip;
    public uint MipLevels;
    public uint First2DArrayFace;
    public uint NumCubes;
}
