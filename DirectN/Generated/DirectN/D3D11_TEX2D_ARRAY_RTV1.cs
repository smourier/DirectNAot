#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/ns-d3d11_3-d3d11_tex2d_array_rtv1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TEX2D_ARRAY_RTV1
{
    public uint MipSlice;
    public uint FirstArraySlice;
    public uint ArraySize;
    public uint PlaneSlice;
}
