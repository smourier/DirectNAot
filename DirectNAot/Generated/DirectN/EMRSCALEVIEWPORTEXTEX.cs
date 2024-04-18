namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrscaleviewportextex
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSCALEVIEWPORTEXTEX
{
    public EMR emr;
    public int xNum;
    public int xDenom;
    public int yNum;
    public int yDenom;
}
