namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enumlogfontexw
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMLOGFONTEXW
{
    public LOGFONTW elfLogFont;
    public InlineArraySystemChar64 elfFullName;
    public InlineArraySystemChar32 elfStyle;
    public InlineArraySystemChar32 elfScript;
}
