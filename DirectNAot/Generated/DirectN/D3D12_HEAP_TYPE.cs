namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_heap_type
public enum D3D12_HEAP_TYPE
{
    D3D12_HEAP_TYPE_DEFAULT = 1,
    D3D12_HEAP_TYPE_UPLOAD = 2,
    D3D12_HEAP_TYPE_READBACK = 3,
    D3D12_HEAP_TYPE_CUSTOM = 4,
    D3D12_HEAP_TYPE_GPU_UPLOAD = 5,
}
