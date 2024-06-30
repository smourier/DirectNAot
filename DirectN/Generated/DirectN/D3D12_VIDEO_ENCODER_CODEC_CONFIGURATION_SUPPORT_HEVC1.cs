#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1
{
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS SupportFlags;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize;
    public byte max_transform_hierarchy_depth_inter;
    public byte max_transform_hierarchy_depth_intra;
    public uint allowed_diff_cu_chroma_qp_offset_depth_values;
    public uint allowed_log2_sao_offset_scale_luma_values;
    public uint allowed_log2_sao_offset_scale_chroma_values;
    public uint allowed_log2_max_transform_skip_block_size_minus2_values;
    public uint allowed_chroma_qp_offset_list_len_minus1_values;
    public InlineArrayUInt32_6 allowed_cb_qp_offset_list_values;
    public InlineArrayUInt32_6 allowed_cr_qp_offset_list_values;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS1 SupportFlags1;
}
