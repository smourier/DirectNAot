#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MFCameraIntrinsic_CameraModel
{
    public float FocalLength_x;
    public float FocalLength_y;
    public float PrincipalPoint_x;
    public float PrincipalPoint_y;
}
