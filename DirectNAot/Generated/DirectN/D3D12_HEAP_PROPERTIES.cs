namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_heap_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_HEAP_PROPERTIES
{
    public D3D12_HEAP_TYPE Type;
    public D3D12_CPU_PAGE_PROPERTY CPUPageProperty;
    public D3D12_MEMORY_POOL MemoryPoolPreference;
    public uint CreationNodeMask;
    public uint VisibleNodeMask;
}
