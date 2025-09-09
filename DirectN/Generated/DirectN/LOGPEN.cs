#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-logpen
public partial struct LOGPEN
{
    public uint lopnStyle;
    public POINT lopnWidth;
    public COLORREF lopnColor;
}
