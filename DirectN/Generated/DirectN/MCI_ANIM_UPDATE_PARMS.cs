#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_ANIM_UPDATE_PARMS
{
    public nuint dwCallback;
    public RECT rc;
    public HDC hDC;
}
