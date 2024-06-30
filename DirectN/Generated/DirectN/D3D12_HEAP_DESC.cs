#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_heap_desc
public partial struct D3D12_HEAP_DESC
{
    public ulong SizeInBytes;
    public D3D12_HEAP_PROPERTIES Properties;
    public ulong Alignment;
    public D3D12_HEAP_FLAGS Flags;
}
