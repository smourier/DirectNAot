namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrextcreatepen
[StructLayout(LayoutKind.Sequential)]
public partial struct EMREXTCREATEPEN
{
    public EMR emr;
    public uint ihPen;
    public uint offBmi;
    public uint cbBmi;
    public uint offBits;
    public uint cbBits;
    public EXTLOGPEN32 elp;
}
