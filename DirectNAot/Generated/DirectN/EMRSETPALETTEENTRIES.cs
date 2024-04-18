namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetpaletteentries
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETPALETTEENTRIES
{
    public EMR emr;
    public uint ihPal;
    public uint iStart;
    public uint cEntries;
    public InlineArrayPALETTEENTRY1 aPalEntries; // variable-length array placeholder
}
