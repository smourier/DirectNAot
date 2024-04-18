namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_gpu_descriptor_handle
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_GPU_DESCRIPTOR_HANDLE
{
    public ulong ptr;
}
