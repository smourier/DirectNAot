namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_ANIM_STEP_PARMS
{
    public nuint dwCallback;
    public uint dwFrames;
}
