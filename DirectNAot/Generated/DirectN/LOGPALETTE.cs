namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-logpalette
[StructLayout(LayoutKind.Sequential)]
public partial struct LOGPALETTE
{
    public ushort palVersion;
    public ushort palNumEntries;
    public InlineArrayPALETTEENTRY1 palPalEntry; // variable-length array placeholder
}
