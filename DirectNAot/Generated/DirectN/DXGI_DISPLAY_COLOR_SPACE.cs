#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_display_color_space
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_DISPLAY_COLOR_SPACE
{
    public InlineArraySingle16 PrimaryCoordinates;
    public InlineArraySingle32 WhitePoints;
}
