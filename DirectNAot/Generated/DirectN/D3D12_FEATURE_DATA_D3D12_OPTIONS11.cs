namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options11
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS11
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AtomicInt64OnDescriptorHeapResourceSupported;
}
