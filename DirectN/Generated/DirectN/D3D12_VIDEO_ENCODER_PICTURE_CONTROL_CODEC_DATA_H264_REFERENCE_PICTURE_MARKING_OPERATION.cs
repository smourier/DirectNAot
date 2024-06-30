#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_control_codec_data_h264_reference_picture_marking_operation
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION
{
    public byte memory_management_control_operation;
    public uint difference_of_pic_nums_minus1;
    public uint long_term_pic_num;
    public uint long_term_frame_idx;
    public uint max_long_term_frame_idx_plus1;
}
