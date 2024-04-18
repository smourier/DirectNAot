namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_gpu_virtual_address_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT
{
    public uint MaxGPUVirtualAddressBitsPerResource;
    public uint MaxGPUVirtualAddressBitsPerProcess;
}
