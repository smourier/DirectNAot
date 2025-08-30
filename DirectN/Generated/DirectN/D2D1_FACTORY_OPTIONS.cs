#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_factory_options
public partial struct D2D1_FACTORY_OPTIONS : IValueGet<D2D1_DEBUG_LEVEL>
{
    public D2D1_DEBUG_LEVEL debugLevel;
    
    readonly D2D1_DEBUG_LEVEL IValueGet<D2D1_DEBUG_LEVEL>.GetValue() => debugLevel;
    readonly object? IValueGet.GetValue() => debugLevel;
}
