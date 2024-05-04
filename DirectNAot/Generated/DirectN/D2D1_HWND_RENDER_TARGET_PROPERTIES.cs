#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_hwnd_render_target_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_HWND_RENDER_TARGET_PROPERTIES
{
    public HWND hwnd;
    public D2D_SIZE_U pixelSize;
    public D2D1_PRESENT_OPTIONS presentOptions;
}
