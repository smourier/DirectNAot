#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-am_framestep_step
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_FRAMESTEP_STEP
{
    public uint dwFramesToStep;
}
