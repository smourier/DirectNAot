#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_command_queue_desc
public partial struct D3D12_COMMAND_QUEUE_DESC
{
    public D3D12_COMMAND_LIST_TYPE Type;
    public int Priority;
    public D3D12_COMMAND_QUEUE_FLAGS Flags;
    public uint NodeMask;
}
