#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effects/ne-d2d1effects-d2d1_directionalblur_prop
public enum D2D1_DIRECTIONALBLUR_PROP
{
    D2D1_DIRECTIONALBLUR_PROP_STANDARD_DEVIATION = 0,
    D2D1_DIRECTIONALBLUR_PROP_ANGLE = 1,
    D2D1_DIRECTIONALBLUR_PROP_OPTIMIZATION = 2,
    D2D1_DIRECTIONALBLUR_PROP_BORDER_MODE = 3,
}
