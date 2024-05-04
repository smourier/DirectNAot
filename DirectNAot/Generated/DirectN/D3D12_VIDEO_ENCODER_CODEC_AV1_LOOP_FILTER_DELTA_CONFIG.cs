#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG
{
    public ulong DeltaLFPresent;
    public ulong DeltaLFMulti;
    public ulong DeltaLFRes;
}
