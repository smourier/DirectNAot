#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-analogvideoinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct ANALOGVIDEOINFO
{
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwActiveWidth;
    public uint dwActiveHeight;
    public long AvgTimePerFrame;
}
