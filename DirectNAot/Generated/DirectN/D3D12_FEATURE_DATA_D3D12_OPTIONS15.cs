namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS15
{
    [MarshalAs(UnmanagedType.U4)]
    public bool TriangleFanSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DynamicIndexBufferStripCutSupported;
}
