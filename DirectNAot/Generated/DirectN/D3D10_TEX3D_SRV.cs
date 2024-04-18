namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_tex3d_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_TEX3D_SRV
{
    public uint MostDetailedMip;
    public uint MipLevels;
}
