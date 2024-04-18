namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcolorcorrectpalette
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRCOLORCORRECTPALETTE
{
    public EMR emr;
    public uint ihPalette;
    public uint nFirstEntry;
    public uint nPalEntries;
    public uint nReserved;
}
