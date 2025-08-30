#nullable enable
namespace DirectN;

public partial struct D3D12_IB_STRIP_CUT_VALUE : IValueGet<D3D12_INDEX_BUFFER_STRIP_CUT_VALUE>
{
    public D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IndexBufferStripCutValue;
    
    readonly D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IValueGet<D3D12_INDEX_BUFFER_STRIP_CUT_VALUE>.GetValue() => IndexBufferStripCutValue;
    readonly object? IValueGet.GetValue() => IndexBufferStripCutValue;
}
