namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_reference_picture_descriptor_hevc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC
{
    public uint ReconstructedPictureResourceIndex;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsRefUsedByCurrentPic;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsLongTermReference;
    public uint PictureOrderCountNumber;
    public uint TemporalLayerIndex;
}
