﻿#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG
{
    public InlineArrayUInt64_2 LoopFilterLevel;
    public ulong LoopFilterLevelU;
    public ulong LoopFilterLevelV;
    public ulong LoopFilterSharpnessLevel;
    public ulong LoopFilterDeltaEnabled;
    public ulong UpdateRefDelta;
    public InlineArrayInt64_8 RefDeltas;
    public ulong UpdateModeDelta;
    public InlineArrayInt64_2 ModeDeltas;
}
