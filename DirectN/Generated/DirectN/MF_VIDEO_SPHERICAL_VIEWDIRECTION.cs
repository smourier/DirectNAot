#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MF_VIDEO_SPHERICAL_VIEWDIRECTION
{
    public int iHeading;
    public int iPitch;
    public int iRoll;
}
