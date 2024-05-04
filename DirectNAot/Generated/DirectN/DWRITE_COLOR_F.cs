#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/dwrite-color-f
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_COLOR_F
{
    public float r;
    public float g;
    public float b;
    public float a;
}
