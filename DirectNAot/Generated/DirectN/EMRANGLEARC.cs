namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emranglearc
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRANGLEARC
{
    public EMR emr;
    public POINTL ptlCenter;
    public uint nRadius;
    public float eStartAngle;
    public float eSweepAngle;
}
