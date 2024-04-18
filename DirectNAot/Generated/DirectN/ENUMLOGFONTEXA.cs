namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enumlogfontexa
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMLOGFONTEXA
{
    public LOGFONTA elfLogFont;
    public InlineArrayByte64 elfFullName;
    public InlineArrayByte32 elfStyle;
    public InlineArrayByte32 elfScript;
}
