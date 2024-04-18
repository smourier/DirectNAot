namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enumlogfonta
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMLOGFONTA
{
    public LOGFONTA elfLogFont;
    public InlineArrayByte64 elfFullName;
    public InlineArrayByte32 elfStyle;
}
