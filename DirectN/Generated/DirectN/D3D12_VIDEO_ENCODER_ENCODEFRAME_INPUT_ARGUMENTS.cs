#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_encodeframe_input_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS
{
    public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC SequenceControlDesc;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC PictureControlDesc;
    public nint pInputFrame;
    public uint InputFrameSubresource;
    public uint CurrentFrameBitstreamMetadataSize;
}
