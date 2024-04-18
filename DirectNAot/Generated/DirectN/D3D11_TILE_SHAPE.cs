namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/ns-d3d11_2-d3d11_tile_shape
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TILE_SHAPE
{
    public uint WidthInTexels;
    public uint HeightInTexels;
    public uint DepthInTexels;
}
