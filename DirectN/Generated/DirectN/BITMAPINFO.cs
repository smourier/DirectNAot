#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-bitmapinfo
public partial struct BITMAPINFO
{
    public BITMAPINFOHEADER bmiHeader;
    public InlineArrayRGBQUAD_1 bmiColors; // variable-length array placeholder
}
