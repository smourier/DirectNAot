#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mfcameraintrinsic_pinholecameramodel
public partial struct MFCameraIntrinsic_PinholeCameraModel
{
    public MF_FLOAT2 FocalLength;
    public MF_FLOAT2 PrincipalPoint;
}
