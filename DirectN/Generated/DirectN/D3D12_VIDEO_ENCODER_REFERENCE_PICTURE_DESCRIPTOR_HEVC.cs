#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_reference_picture_descriptor_hevc
public partial struct D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC
{
    public uint ReconstructedPictureResourceIndex;
    public BOOL IsRefUsedByCurrentPic;
    public BOOL IsLongTermReference;
    public uint PictureOrderCountNumber;
    public uint TemporalLayerIndex;
}
