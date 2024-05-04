#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex2d_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TEX2D_SRV
{
    public uint MostDetailedMip;
    public uint MipLevels;
    public uint PlaneSlice;
    public float ResourceMinLODClamp;
}
