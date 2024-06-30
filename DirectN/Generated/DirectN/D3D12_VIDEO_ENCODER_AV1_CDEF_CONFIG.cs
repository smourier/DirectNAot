#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG
{
    public ulong CdefBits;
    public ulong CdefDampingMinus3;
    public InlineArrayUInt64_8 CdefYPriStrength;
    public InlineArrayUInt64_8 CdefUVPriStrength;
    public InlineArrayUInt64_8 CdefYSecStrength;
    public InlineArrayUInt64_8 CdefUVSecStrength;
}
