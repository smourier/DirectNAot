namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_control_codec_data_hevc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC
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
}
