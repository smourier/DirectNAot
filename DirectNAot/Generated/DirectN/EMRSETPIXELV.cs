namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetpixelv
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETPIXELV
{
    public EMR emr;
    public POINTL ptlPixel;
    public COLORREF crColor;
}
