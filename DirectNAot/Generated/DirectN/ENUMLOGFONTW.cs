namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enumlogfontw
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMLOGFONTW
{
    public LOGFONTW elfLogFont;
    public InlineArraySystemChar64 elfFullName;
    public InlineArraySystemChar32 elfStyle;
}
