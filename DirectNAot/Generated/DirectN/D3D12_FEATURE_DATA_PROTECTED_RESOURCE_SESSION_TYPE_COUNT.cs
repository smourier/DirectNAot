namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_protected_resource_session_type_count
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT
{
    public uint NodeIndex;
    public uint Count;
}
