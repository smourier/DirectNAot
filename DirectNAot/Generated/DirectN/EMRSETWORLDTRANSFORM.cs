namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetworldtransform
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETWORLDTRANSFORM
{
    public EMR emr;
    public XFORM xform;
}
