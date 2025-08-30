#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS18 : IValueGet<BOOL>
{
    public BOOL RenderPassesValid;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => RenderPassesValid;
    readonly object? IValueGet.GetValue() => RenderPassesValid;
}
