#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_gpu_virtual_address_support
public partial struct D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT
{
    public uint MaxGPUVirtualAddressBitsPerResource;
    public uint MaxGPUVirtualAddressBitsPerProcess;
}
