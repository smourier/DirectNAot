namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_sampler_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SAMPLER_DESC
{
    public D3D10_FILTER Filter;
    public D3D10_TEXTURE_ADDRESS_MODE AddressU;
    public D3D10_TEXTURE_ADDRESS_MODE AddressV;
    public D3D10_TEXTURE_ADDRESS_MODE AddressW;
    public float MipLODBias;
    public uint MaxAnisotropy;
    public D3D10_COMPARISON_FUNC ComparisonFunc;
    public InlineArraySingle4 BorderColor;
    public float MinLOD;
    public float MaxLOD;
}
