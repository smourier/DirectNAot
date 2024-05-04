#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DRED_PAGE_FAULT_OUTPUT2
{
    public ulong PageFaultVA;
    public nint pHeadExistingAllocationNode;
    public nint pHeadRecentFreedAllocationNode;
    public D3D12_DRED_PAGE_FAULT_FLAGS PageFaultFlags;
}
