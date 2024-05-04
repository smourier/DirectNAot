#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROTECTED_RESOURCES
{
    public uint NodeIndex;
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
    public D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS SupportFlags;
}
