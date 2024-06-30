#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex1d_array_dsv
public partial struct D3D12_TEX1D_ARRAY_DSV
{
    public uint MipSlice;
    public uint FirstArraySlice;
    public uint ArraySize;
}
