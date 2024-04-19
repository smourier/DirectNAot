namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_ANIM_UPDATE_PARMS
{
    public nuint dwCallback;
    public FoundationRECT rc;
    public HDC hDC;
}
