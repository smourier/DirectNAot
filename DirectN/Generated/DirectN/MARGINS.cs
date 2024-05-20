#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/uxtheme/ns-uxtheme-margins
[StructLayout(LayoutKind.Sequential)]
public partial struct MARGINS
{
    public int cxLeftWidth;
    public int cxRightWidth;
    public int cyTopHeight;
    public int cyBottomHeight;
}
