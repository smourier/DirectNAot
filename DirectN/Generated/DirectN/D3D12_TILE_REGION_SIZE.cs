#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tile_region_size
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TILE_REGION_SIZE
{
    public uint NumTiles;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool UseBox;
    public uint Width;
    public ushort Height;
    public ushort Depth;
}
