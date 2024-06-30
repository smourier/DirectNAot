#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex2d_array_srv
public partial struct D3D12_TEX2D_ARRAY_SRV
{
    public uint MostDetailedMip;
    public uint MipLevels;
    public uint FirstArraySlice;
    public uint ArraySize;
    public uint PlaneSlice;
    public float ResourceMinLODClamp;
}
