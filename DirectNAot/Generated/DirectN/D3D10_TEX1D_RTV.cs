namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_tex1d_rtv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_TEX1D_RTV
{
    public uint MipSlice;
}
