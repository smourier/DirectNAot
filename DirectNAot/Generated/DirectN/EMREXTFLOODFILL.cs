namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrextfloodfill
[StructLayout(LayoutKind.Sequential)]
public partial struct EMREXTFLOODFILL
{
    public EMR emr;
    public POINTL ptlStart;
    public COLORREF crColor;
    public uint iMode;
}
