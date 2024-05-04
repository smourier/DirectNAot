#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_sequence_control_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC
{
    public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH IntraRefreshConfig;
    public D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SelectedLayoutMode;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA FrameSubregionsLayoutData;
    public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence;
}
