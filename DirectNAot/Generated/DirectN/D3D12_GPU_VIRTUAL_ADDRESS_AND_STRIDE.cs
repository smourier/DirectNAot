namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_gpu_virtual_address_and_stride
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE
{
    public ulong StartAddress;
    public ulong StrideInBytes;
}
