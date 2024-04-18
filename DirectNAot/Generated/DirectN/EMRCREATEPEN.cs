namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcreatepen
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRCREATEPEN
{
    public EMR emr;
    public uint ihPen;
    public LOGPEN lopn;
}
