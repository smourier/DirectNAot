namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mfcameraintrinsic_distortionmodel
[StructLayout(LayoutKind.Sequential)]
public partial struct MFCameraIntrinsic_DistortionModel
{
    public float Radial_k1;
    public float Radial_k2;
    public float Radial_k3;
    public float Tangential_p1;
    public float Tangential_p2;
}
