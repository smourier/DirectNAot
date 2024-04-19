namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_VIDEOPROCSETTING
{
    public uint Mode;
    public int Min;
    public int Max;
    public int Step;
    public KSCAMERA_EXTENDEDPROP_VALUE VideoProc;
    public ulong Reserved;
}
