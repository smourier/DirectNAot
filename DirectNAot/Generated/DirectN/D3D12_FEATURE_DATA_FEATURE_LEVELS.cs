namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_feature_levels
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_FEATURE_LEVELS
{
    public uint NumFeatureLevels;
    public nint pFeatureLevelsRequested;
    public D3D_FEATURE_LEVEL MaxSupportedFeatureLevel;
}
