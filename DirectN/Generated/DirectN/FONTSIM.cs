#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fontsim
[StructLayout(LayoutKind.Sequential)]
public partial struct FONTSIM
{
    public int dpBold;
    public int dpItalic;
    public int dpBoldItalic;
}
