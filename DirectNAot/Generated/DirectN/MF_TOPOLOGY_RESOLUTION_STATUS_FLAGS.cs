namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_topology_resolution_status_flags
public enum MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS
{
    MF_TOPOLOGY_RESOLUTION_SUCCEEDED = 0,
    MF_OPTIONAL_NODE_REJECTED_MEDIA_TYPE = 1,
    MF_OPTIONAL_NODE_REJECTED_PROTECTED_PROCESS = 2,
}
