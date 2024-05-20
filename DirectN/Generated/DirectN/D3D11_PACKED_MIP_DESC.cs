#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_2/ns-d3d11_2-d3d11_packed_mip_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_PACKED_MIP_DESC
{
    public byte NumStandardMips;
    public byte NumPackedMips;
    public uint NumTilesForPackedMips;
    public uint StartTileIndexInOverallResource;
}
