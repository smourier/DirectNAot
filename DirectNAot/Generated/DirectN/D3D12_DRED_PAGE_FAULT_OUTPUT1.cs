namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DRED_PAGE_FAULT_OUTPUT1
{
    public ulong PageFaultVA;
    public nint pHeadExistingAllocationNode;
    public nint pHeadRecentFreedAllocationNode;
}
