namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_topology_type
public enum MF_TOPOLOGY_TYPE
{
    MF_TOPOLOGY_OUTPUT_NODE = 0,
    MF_TOPOLOGY_SOURCESTREAM_NODE = 1,
    MF_TOPOLOGY_TRANSFORM_NODE = 2,
    MF_TOPOLOGY_TEE_NODE = 3,
    MF_TOPOLOGY_MAX = -1,
}
