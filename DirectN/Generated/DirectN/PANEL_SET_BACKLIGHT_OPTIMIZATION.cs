#nullable enable
namespace DirectN;

public partial struct PANEL_SET_BACKLIGHT_OPTIMIZATION : IValueGet<BACKLIGHT_OPTIMIZATION_LEVEL>
{
    public BACKLIGHT_OPTIMIZATION_LEVEL Level;
    
    readonly BACKLIGHT_OPTIMIZATION_LEVEL IValueGet<BACKLIGHT_OPTIMIZATION_LEVEL>.GetValue() => Level;
    readonly object? IValueGet.GetValue() => Level;
}
