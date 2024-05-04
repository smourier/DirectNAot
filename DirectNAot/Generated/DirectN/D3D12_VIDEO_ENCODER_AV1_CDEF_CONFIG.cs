#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG
{
    public ulong CdefBits;
    public ulong CdefDampingMinus3;
    public InlineArrayUInt648 CdefYPriStrength;
    public InlineArrayUInt648 CdefUVPriStrength;
    public InlineArrayUInt648 CdefYSecStrength;
    public InlineArrayUInt648 CdefUVSecStrength;
}
