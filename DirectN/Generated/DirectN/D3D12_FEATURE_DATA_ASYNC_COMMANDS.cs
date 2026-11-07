#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_ASYNC_COMMANDS : IValueGet<D3D12_ASYNC_COMMANDS_IMPL>
{
    public D3D12_ASYNC_COMMANDS_IMPL Impl;
    
    readonly D3D12_ASYNC_COMMANDS_IMPL IValueGet<D3D12_ASYNC_COMMANDS_IMPL>.GetValue() => Impl;
    readonly object? IValueGet.GetValue() => Impl;
}
