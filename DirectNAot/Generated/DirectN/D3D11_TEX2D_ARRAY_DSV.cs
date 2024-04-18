namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_tex2d_array_dsv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TEX2D_ARRAY_DSV
{
    public uint MipSlice;
    public uint FirstArraySlice;
    public uint ArraySize;
}
