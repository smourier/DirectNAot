#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_NODE_OUTPUT_OVERRIDES
{
    public uint OutputIndex;
    public nint pNewName;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool pAllowSparseNodes;
    public nint pMaxRecords;
    public nint pMaxRecordsSharedWithOutputIndex;
}
