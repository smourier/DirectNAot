#nullable enable
namespace DirectN;

public partial struct D3D12_NODE_OUTPUT_OVERRIDES
{
    public uint OutputIndex;
    public nint pNewName;
    public nint pAllowSparseNodes;
    public nint pMaxRecords;
    public nint pMaxRecordsSharedWithOutputIndex;
}
