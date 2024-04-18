namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcreatedibpatternbrushpt
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRCREATEDIBPATTERNBRUSHPT
{
    public EMR emr;
    public uint ihBrush;
    public uint iUsage;
    public uint offBmi;
    public uint cbBmi;
    public uint offBits;
    public uint cbBits;
}
