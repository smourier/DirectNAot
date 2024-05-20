#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILE_COUNT
{
    public uint NodeIndex;
    public uint ProfileCount;
}
