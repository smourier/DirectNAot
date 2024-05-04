#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_ANIM_PLAY_PARMS
{
    public nuint dwCallback;
    public uint dwFrom;
    public uint dwTo;
    public uint dwSpeed;
}
