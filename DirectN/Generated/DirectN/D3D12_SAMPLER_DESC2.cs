#nullable enable
namespace DirectN;

public partial struct D3D12_SAMPLER_DESC2
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public InlineArraySingle_4 FloatBorderColor;
        
        [FieldOffset(0)]
        public InlineArrayUInt32_4 UintBorderColor;
    }
    
    public D3D12_FILTER Filter;
    public D3D12_TEXTURE_ADDRESS_MODE AddressU;
    public D3D12_TEXTURE_ADDRESS_MODE AddressV;
    public D3D12_TEXTURE_ADDRESS_MODE AddressW;
    public float MipLODBias;
    public uint MaxAnisotropy;
    public D3D12_COMPARISON_FUNC ComparisonFunc;
    public _Anonymous_e__Union Anonymous;
    public float MinLOD;
    public float MaxLOD;
    public D3D12_SAMPLER_FLAGS Flags;
}
