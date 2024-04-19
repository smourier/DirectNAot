namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MFExtendedCameraIntrinsic_IntrinsicModel
{
    public uint Width;
    public uint Height;
    public uint SplitFrameId;
    public MFCameraIntrinsic_CameraModel CameraModel;
}
