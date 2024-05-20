#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_control_codec_data_h264_reference_picture_list_modification_operation
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION
{
    public byte modification_of_pic_nums_idc;
    public uint abs_diff_pic_num_minus1;
    public uint long_term_pic_num;
}
