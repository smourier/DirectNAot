#nullable enable
namespace DirectN;

public partial struct D3D11_FEATURE_DATA_ARCHITECTURE_INFO : IValueGet<BOOL>
{
    public BOOL TileBasedDeferredRenderer;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => TileBasedDeferredRenderer;
    readonly object? IValueGet.GetValue() => TileBasedDeferredRenderer;
}
