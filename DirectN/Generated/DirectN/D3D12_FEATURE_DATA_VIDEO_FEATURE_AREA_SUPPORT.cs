#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT
{
    public uint NodeIndex;
    public BOOL VideoDecodeSupport;
    public BOOL VideoProcessSupport;
    public BOOL VideoEncodeSupport;
}
