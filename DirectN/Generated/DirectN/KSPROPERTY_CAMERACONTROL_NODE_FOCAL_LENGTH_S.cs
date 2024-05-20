#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_CAMERACONTROL_NODE_FOCAL_LENGTH_S
{
    public KSNODEPROPERTY NodeProperty;
    public int lOcularFocalLength;
    public int lObjectiveFocalLengthMin;
    public int lObjectiveFocalLengthMax;
}
