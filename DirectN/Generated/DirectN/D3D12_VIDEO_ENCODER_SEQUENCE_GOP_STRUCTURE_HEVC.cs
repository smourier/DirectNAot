#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_sequence_gop_structure_hevc
public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC
{
    public uint GOPLength;
    public uint PPicturePeriod;
    public byte log2_max_pic_order_cnt_lsb_minus4;
}
