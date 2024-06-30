#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_dred_allocation_node
public partial struct D3D12_DRED_ALLOCATION_NODE
{
    public nint ObjectNameA;
    public PWSTR ObjectNameW;
    public D3D12_DRED_ALLOCATION_TYPE AllocationType;
    public nint pNext;
}
