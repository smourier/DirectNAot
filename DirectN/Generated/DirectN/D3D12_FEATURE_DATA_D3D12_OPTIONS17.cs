#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS17
{
    [MarshalAs(UnmanagedType.U4)]
    public bool NonNormalizedCoordinateSamplersSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ManualWriteTrackingResourceSupported;
}
