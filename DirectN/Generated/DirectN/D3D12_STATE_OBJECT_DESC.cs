#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_state_object_desc
public partial struct D3D12_STATE_OBJECT_DESC
{
    public D3D12_STATE_OBJECT_TYPE Type;
    public uint NumSubobjects;
    public nint pSubobjects;
}
