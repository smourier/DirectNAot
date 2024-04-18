namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_subresource_range_uint64
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SUBRESOURCE_RANGE_UINT64
{
    public uint Subresource;
    public D3D12_RANGE_UINT64 Range;
}
