#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/ns-d3d11_2-d3d11_tile_region_size
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TILE_REGION_SIZE
{
    public uint NumTiles;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bUseBox;
    public uint Width;
    public ushort Height;
    public ushort Depth;
}
