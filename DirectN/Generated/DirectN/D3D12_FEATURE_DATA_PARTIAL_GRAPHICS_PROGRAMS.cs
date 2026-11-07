#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_PARTIAL_GRAPHICS_PROGRAMS : IValueGet<D3D12_PARTIAL_GRAPHICS_PROGRAMS_TIER>
{
    public D3D12_PARTIAL_GRAPHICS_PROGRAMS_TIER PartialGraphicsProgramsTier;
    
    readonly D3D12_PARTIAL_GRAPHICS_PROGRAMS_TIER IValueGet<D3D12_PARTIAL_GRAPHICS_PROGRAMS_TIER>.GetValue() => PartialGraphicsProgramsTier;
    readonly object? IValueGet.GetValue() => PartialGraphicsProgramsTier;
}
