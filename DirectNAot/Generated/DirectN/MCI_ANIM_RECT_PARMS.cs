namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_ANIM_RECT_PARMS
{
    public nuint dwCallback;
    public RECT rc;
}
