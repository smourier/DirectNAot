namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-bitmapinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct BITMAPINFO
{
    public BITMAPINFOHEADER bmiHeader;
    public InlineArrayRGBQUAD1 bmiColors; // variable-length array placeholder
}
