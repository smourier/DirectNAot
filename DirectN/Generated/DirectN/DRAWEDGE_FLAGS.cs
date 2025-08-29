#nullable enable
namespace DirectN;

[Flags]
public enum DRAWEDGE_FLAGS : uint
{
    BDR_RAISEDOUTER = 1,
    BDR_SUNKENOUTER = 2,
    BDR_RAISEDINNER = 4,
    BDR_SUNKENINNER = 8,
    BDR_OUTER = 3,
    BDR_INNER = 12,
    BDR_RAISED = 5,
    BDR_SUNKEN = 10,
    EDGE_RAISED = 5,
    EDGE_SUNKEN = 10,
    EDGE_ETCHED = 6,
    EDGE_BUMP = 9,
}
