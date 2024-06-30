#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_sequence_gop_structure_h264
public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264
{
    public uint GOPLength;
    public uint PPicturePeriod;
    public byte pic_order_cnt_type;
    public byte log2_max_frame_num_minus4;
    public byte log2_max_pic_order_cnt_lsb_minus4;
}
