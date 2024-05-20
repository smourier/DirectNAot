#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_tex1d_array_dsv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_TEX1D_ARRAY_DSV
{
    public uint MipSlice;
    public uint FirstArraySlice;
    public uint ArraySize;
}
