#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TEX2DMS_ARRAY_UAV
{
    public uint FirstArraySlice;
    public uint ArraySize;
}
