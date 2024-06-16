#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS16
{
    public BOOL DynamicDepthBiasSupported;
    public BOOL GPUUploadHeapSupported;
}
