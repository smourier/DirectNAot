#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_sampler_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_SAMPLER_DESC
{
    public D3D11_FILTER Filter;
    public D3D11_TEXTURE_ADDRESS_MODE AddressU;
    public D3D11_TEXTURE_ADDRESS_MODE AddressV;
    public D3D11_TEXTURE_ADDRESS_MODE AddressW;
    public float MipLODBias;
    public uint MaxAnisotropy;
    public D3D11_COMPARISON_FUNC ComparisonFunc;
    public InlineArraySingle4 BorderColor;
    public float MinLOD;
    public float MaxLOD;
}
