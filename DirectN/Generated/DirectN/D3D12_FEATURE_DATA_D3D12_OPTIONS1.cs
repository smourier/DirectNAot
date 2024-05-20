#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS1
{
    [MarshalAs(UnmanagedType.U4)]
    public bool WaveOps;
    public uint WaveLaneCountMin;
    public uint WaveLaneCountMax;
    public uint TotalLaneCount;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ExpandedComputeResourceStates;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Int64ShaderOps;
}
