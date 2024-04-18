namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_packed_mip_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_PACKED_MIP_INFO
{
    public byte NumStandardMips;
    public byte NumPackedMips;
    public uint NumTilesForPackedMips;
    public uint StartTileIndexInOverallResource;
}
