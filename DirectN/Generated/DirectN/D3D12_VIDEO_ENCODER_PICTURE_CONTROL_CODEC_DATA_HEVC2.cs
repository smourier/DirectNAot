#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC2
{
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC FrameType;
    public uint slice_pic_parameter_set_id;
    public uint PictureOrderCountNumber;
    public uint TemporalLayerIndex;
    public uint List0ReferenceFramesCount;
    public nint pList0ReferenceFrames;
    public uint List1ReferenceFramesCount;
    public nint pList1ReferenceFrames;
    public uint ReferenceFramesReconPictureDescriptorsCount;
    public nint pReferenceFramesReconPictureDescriptors;
    public uint List0RefPicModificationsCount;
    public nint pList0RefPicModifications;
    public uint List1RefPicModificationsCount;
    public nint pList1RefPicModifications;
    public uint QPMapValuesCount;
    public nint pRateControlQPMap;
    public byte diff_cu_chroma_qp_offset_depth;
    public byte log2_sao_offset_scale_luma;
    public byte log2_sao_offset_scale_chroma;
    public byte log2_max_transform_skip_block_size_minus2;
    public byte chroma_qp_offset_list_len_minus1;
    public InlineArrayCHAR_6 cb_qp_offset_list;
    public InlineArrayCHAR_6 cr_qp_offset_list;
    public uint num_ref_idx_l0_active_minus1;
    public uint num_ref_idx_l1_active_minus1;
}
