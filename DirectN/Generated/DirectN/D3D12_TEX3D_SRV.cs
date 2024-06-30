#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex3d_srv
public partial struct D3D12_TEX3D_SRV
{
    public uint MostDetailedMip;
    public uint MipLevels;
    public float ResourceMinLODClamp;
}
