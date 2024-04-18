namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_query_heap_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_QUERY_HEAP_DESC
{
    public D3D12_QUERY_HEAP_TYPE Type;
    public uint Count;
    public uint NodeMask;
}
