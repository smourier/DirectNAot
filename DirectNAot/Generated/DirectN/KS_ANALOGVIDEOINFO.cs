namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_ANALOGVIDEOINFO
{
    public FoundationRECT rcSource;
    public FoundationRECT rcTarget;
    public uint dwActiveWidth;
    public uint dwActiveHeight;
    public long AvgTimePerFrame;
}
