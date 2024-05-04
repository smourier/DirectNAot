#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_color_rgba
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_COLOR_RGBA
{
    public float R;
    public float G;
    public float B;
    public float A;
}
