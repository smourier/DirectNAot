#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_texcube_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TEXCUBE_SRV
{
    public uint MostDetailedMip;
    public uint MipLevels;
}
