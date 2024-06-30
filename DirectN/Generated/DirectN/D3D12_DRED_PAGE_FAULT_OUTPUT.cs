#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_dred_page_fault_output
public partial struct D3D12_DRED_PAGE_FAULT_OUTPUT
{
    public ulong PageFaultVA;
    public nint pHeadExistingAllocationNode;
    public nint pHeadRecentFreedAllocationNode;
}
