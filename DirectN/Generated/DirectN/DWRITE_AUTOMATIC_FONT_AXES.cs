#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ne-dwrite_3-dwrite_automatic_font_axes
[Flags]
public enum DWRITE_AUTOMATIC_FONT_AXES
{
    DWRITE_AUTOMATIC_FONT_AXES_NONE = 0,
    DWRITE_AUTOMATIC_FONT_AXES_OPTICAL_SIZE = 1,
}
