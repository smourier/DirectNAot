namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-analogvideoinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct ANALOGVIDEOINFO
{
    public FoundationRECT rcSource;
    public FoundationRECT rcTarget;
    public uint dwActiveWidth;
    public uint dwActiveHeight;
    public long AvgTimePerFrame;
}
