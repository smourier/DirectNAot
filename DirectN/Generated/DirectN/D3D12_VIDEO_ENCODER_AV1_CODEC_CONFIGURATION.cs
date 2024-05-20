#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION
{
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS FeatureFlags;
    public uint OrderHintBitsMinus1;
}
