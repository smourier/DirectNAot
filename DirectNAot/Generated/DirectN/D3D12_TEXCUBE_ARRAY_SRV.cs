namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_texcube_array_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TEXCUBE_ARRAY_SRV
{
    public uint MostDetailedMip;
    public uint MipLevels;
    public uint First2DArrayFace;
    public uint NumCubes;
    public float ResourceMinLODClamp;
}
