namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_subresource_tiling
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SUBRESOURCE_TILING
{
    public uint WidthInTiles;
    public ushort HeightInTiles;
    public ushort DepthInTiles;
    public uint StartTileIndexInOverallResource;
}
