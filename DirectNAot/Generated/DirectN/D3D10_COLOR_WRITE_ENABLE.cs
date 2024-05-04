#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_color_write_enable
public enum D3D10_COLOR_WRITE_ENABLE
{
    D3D10_COLOR_WRITE_ENABLE_RED = 1,
    D3D10_COLOR_WRITE_ENABLE_GREEN = 2,
    D3D10_COLOR_WRITE_ENABLE_BLUE = 4,
    D3D10_COLOR_WRITE_ENABLE_ALPHA = 8,
    D3D10_COLOR_WRITE_ENABLE_ALL = 15,
}
