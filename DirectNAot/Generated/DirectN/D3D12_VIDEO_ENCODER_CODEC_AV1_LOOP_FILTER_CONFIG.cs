namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG
{
    public InlineArrayUInt642 LoopFilterLevel;
    public ulong LoopFilterLevelU;
    public ulong LoopFilterLevelV;
    public ulong LoopFilterSharpnessLevel;
    public ulong LoopFilterDeltaEnabled;
    public ulong UpdateRefDelta;
    public InlineArrayInt648 RefDeltas;
    public ulong UpdateModeDelta;
    public InlineArrayInt642 ModeDeltas;
}
