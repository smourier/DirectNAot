#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_CAMERAOFFSET
{
    public int PitchAngle;
    public int YawAngle;
    public uint Flag;
    public uint Reserved;
}
