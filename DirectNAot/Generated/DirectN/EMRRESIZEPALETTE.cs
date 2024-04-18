namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrresizepalette
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRRESIZEPALETTE
{
    public EMR emr;
    public uint ihPal;
    public uint cEntries;
}
