#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS16
{
    [MarshalAs(UnmanagedType.U4)]
    public bool DynamicDepthBiasSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool GPUUploadHeapSupported;
}
