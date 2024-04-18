namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_command_queue_priority
public enum D3D12_COMMAND_QUEUE_PRIORITY
{
    D3D12_COMMAND_QUEUE_PRIORITY_NORMAL = 0,
    D3D12_COMMAND_QUEUE_PRIORITY_HIGH = 100,
    D3D12_COMMAND_QUEUE_PRIORITY_GLOBAL_REALTIME = 10000,
}
