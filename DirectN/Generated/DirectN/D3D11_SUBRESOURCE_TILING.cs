#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/ns-d3d11_2-d3d11_subresource_tiling
public partial struct D3D11_SUBRESOURCE_TILING
{
    public uint WidthInTiles;
    public ushort HeightInTiles;
    public ushort DepthInTiles;
    public uint StartTileIndexInOverallResource;
}
