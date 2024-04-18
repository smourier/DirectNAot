namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emroffsetcliprgn
[StructLayout(LayoutKind.Sequential)]
public partial struct EMROFFSETCLIPRGN
{
    public EMR emr;
    public POINTL ptlOffset;
}
