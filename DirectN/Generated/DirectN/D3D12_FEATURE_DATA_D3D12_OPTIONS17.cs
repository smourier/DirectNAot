#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS17
{
    public BOOL NonNormalizedCoordinateSamplersSupported;
    public BOOL ManualWriteTrackingResourceSupported;
}
