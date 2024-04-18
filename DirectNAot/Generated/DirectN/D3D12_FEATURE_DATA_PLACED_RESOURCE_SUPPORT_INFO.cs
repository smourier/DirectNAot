namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO
{
    public DXGI_FORMAT Format;
    public D3D12_RESOURCE_DIMENSION Dimension;
    public D3D12_HEAP_PROPERTIES DestHeapProperties;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Supported;
}
