#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_gpu_virtual_address_range_and_stride
public partial struct D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE
{
    public ulong StartAddress;
    public ulong SizeInBytes;
    public ulong StrideInBytes;
}
