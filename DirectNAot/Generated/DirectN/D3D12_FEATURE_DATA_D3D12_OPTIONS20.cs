namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS20
{
    [MarshalAs(UnmanagedType.U4)]
    public bool ComputeOnlyWriteWatchSupported;
    public D3D12_RECREATE_AT_TIER RecreateAtTier;
}
