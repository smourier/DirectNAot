namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetarcdirection
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETARCDIRECTION
{
    public EMR emr;
    public uint iArcDirection;
}
