namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO
{
    public D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION TransformationType;
    public InlineArrayInt328 TransformationMatrix;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool InvalidAffineSet;
}
