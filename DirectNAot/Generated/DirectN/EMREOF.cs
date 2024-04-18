namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emreof
[StructLayout(LayoutKind.Sequential)]
public partial struct EMREOF
{
    public EMR emr;
    public uint nPalEntries;
    public uint offPalEntries;
    public uint nSizeLast;
}
