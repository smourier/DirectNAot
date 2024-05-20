#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_state_subobject
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_STATE_SUBOBJECT
{
    public D3D12_STATE_SUBOBJECT_TYPE Type;
    public nint pDesc;
}
