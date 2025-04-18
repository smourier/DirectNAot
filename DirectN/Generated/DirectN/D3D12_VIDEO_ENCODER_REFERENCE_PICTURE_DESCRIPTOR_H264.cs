#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_reference_picture_descriptor_h264
public partial struct D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264
{
    public uint ReconstructedPictureResourceIndex;
    public BOOL IsLongTermReference;
    public uint LongTermPictureIdx;
    public uint PictureOrderCountNumber;
    public uint FrameDecodingOrderNumber;
    public uint TemporalLayerIndex;
}
