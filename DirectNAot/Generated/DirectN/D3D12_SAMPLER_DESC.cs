#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_sampler_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SAMPLER_DESC
{
    public D3D12_FILTER Filter;
    public D3D12_TEXTURE_ADDRESS_MODE AddressU;
    public D3D12_TEXTURE_ADDRESS_MODE AddressV;
    public D3D12_TEXTURE_ADDRESS_MODE AddressW;
    public float MipLODBias;
    public uint MaxAnisotropy;
    public D3D12_COMPARISON_FUNC ComparisonFunc;
    public InlineArraySingle_4 BorderColor;
    public float MinLOD;
    public float MaxLOD;
}
