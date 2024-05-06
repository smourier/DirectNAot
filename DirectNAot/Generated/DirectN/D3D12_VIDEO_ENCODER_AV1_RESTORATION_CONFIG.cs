#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG
{
    public InlineArrayD3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_3 FrameRestorationType;
    public InlineArrayD3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_3 LoopRestorationPixelSize;
}
