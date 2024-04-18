namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DRED_ALLOCATION_NODE1
{
    public nint ObjectNameA;
    public PWSTR ObjectNameW;
    public D3D12_DRED_ALLOCATION_TYPE AllocationType;
    public nint pNext;
    public nint pObject;
}
