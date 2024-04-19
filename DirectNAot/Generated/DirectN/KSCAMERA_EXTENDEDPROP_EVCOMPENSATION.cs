namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_EVCOMPENSATION
{
    public uint Mode;
    public int Min;
    public int Max;
    public int Value;
    public ulong Reserved;
}
