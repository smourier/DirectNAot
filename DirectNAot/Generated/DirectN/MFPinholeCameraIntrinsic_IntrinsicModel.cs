#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mfpinholecameraintrinsic_intrinsicmodel
[StructLayout(LayoutKind.Sequential)]
public partial struct MFPinholeCameraIntrinsic_IntrinsicModel
{
    public uint Width;
    public uint Height;
    public MFCameraIntrinsic_PinholeCameraModel CameraModel;
    public MFCameraIntrinsic_DistortionModel DistortionModel;
}
