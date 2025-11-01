#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_TIGHT_ALIGNMENT : IValueGet<D3D12_TIGHT_ALIGNMENT_TIER>
{
    public D3D12_TIGHT_ALIGNMENT_TIER SupportTier;
    
    readonly D3D12_TIGHT_ALIGNMENT_TIER IValueGet<D3D12_TIGHT_ALIGNMENT_TIER>.GetValue() => SupportTier;
    readonly object? IValueGet.GetValue() => SupportTier;
}
