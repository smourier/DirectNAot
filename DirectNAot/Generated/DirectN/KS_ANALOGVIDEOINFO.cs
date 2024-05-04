namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_ANALOGVIDEOINFO
{
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwActiveWidth;
    public uint dwActiveHeight;
    public long AvgTimePerFrame;
}
