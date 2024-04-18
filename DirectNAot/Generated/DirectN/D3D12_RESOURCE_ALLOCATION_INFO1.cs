namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_resource_allocation_info1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RESOURCE_ALLOCATION_INFO1
{
    public ulong Offset;
    public ulong Alignment;
    public ulong SizeInBytes;
}
