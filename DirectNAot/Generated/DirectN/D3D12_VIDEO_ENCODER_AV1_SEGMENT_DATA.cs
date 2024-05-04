#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA
{
    public ulong EnabledFeatures;
    public InlineArrayInt648 FeatureValue;
}
