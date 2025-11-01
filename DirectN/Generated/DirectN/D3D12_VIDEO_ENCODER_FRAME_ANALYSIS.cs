#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_FRAME_ANALYSIS
{
    public nint pDownscaledFrame;
    public ulong Subresource;
    public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES DownscaledReferences;
}
