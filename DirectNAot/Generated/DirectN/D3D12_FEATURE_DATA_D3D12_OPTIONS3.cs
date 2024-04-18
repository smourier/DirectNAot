namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options3
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS3
{
    [MarshalAs(UnmanagedType.U4)]
    public bool CopyQueueTimestampQueriesSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool CastingFullyTypedFormatSupported;
    public D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags;
    public D3D12_VIEW_INSTANCING_TIER ViewInstancingTier;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool BarycentricsSupported;
}
