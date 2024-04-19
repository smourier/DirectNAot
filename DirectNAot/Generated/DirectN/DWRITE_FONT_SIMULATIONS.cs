namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_font_simulations
[Flags]
public enum DWRITE_FONT_SIMULATIONS
{
    DWRITE_FONT_SIMULATIONS_NONE = 0,
    DWRITE_FONT_SIMULATIONS_BOLD = 1,
    DWRITE_FONT_SIMULATIONS_OBLIQUE = 2,
}
