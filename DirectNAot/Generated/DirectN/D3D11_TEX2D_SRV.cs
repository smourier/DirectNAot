#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_tex2d_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TEX2D_SRV
{
    public uint MostDetailedMip;
    public uint MipLevels;
}
