#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_state_object_config
public partial struct D3D12_STATE_OBJECT_CONFIG : IValueGet<D3D12_STATE_OBJECT_FLAGS>
{
    public D3D12_STATE_OBJECT_FLAGS Flags;
    
    readonly D3D12_STATE_OBJECT_FLAGS IValueGet<D3D12_STATE_OBJECT_FLAGS>.GetValue() => Flags;
    readonly object? IValueGet.GetValue() => Flags;
}
