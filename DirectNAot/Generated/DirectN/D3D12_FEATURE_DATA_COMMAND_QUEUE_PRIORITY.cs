#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_command_queue_priority
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY
{
    public D3D12_COMMAND_LIST_TYPE CommandListType;
    public uint Priority;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PriorityForTypeIsSupported;
}
