#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_print_control_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_PRINT_CONTROL_PROPERTIES
{
    public D2D1_PRINT_FONT_SUBSET_MODE fontSubset;
    public float rasterDPI;
    public D2D1_COLOR_SPACE colorSpace;
}
