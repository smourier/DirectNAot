#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_strikethrough
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_STRIKETHROUGH
{
    public float width;
    public float thickness;
    public float offset;
    public DWRITE_READING_DIRECTION readingDirection;
    public DWRITE_FLOW_DIRECTION flowDirection;
    public PWSTR localeName;
    public DWRITE_MEASURING_MODE measuringMode;
}
