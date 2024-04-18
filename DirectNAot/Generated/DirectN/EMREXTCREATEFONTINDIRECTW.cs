namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrextcreatefontindirectw
[StructLayout(LayoutKind.Sequential)]
public partial struct EMREXTCREATEFONTINDIRECTW
{
    public EMR emr;
    public uint ihFont;
    public EXTLOGFONTW elfw;
}
