#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_d3dformat_data
public partial struct DXVAHD_STREAM_STATE_D3DFORMAT_DATA : IValueGet<D3DFORMAT>
{
    public D3DFORMAT Format;
    
    readonly D3DFORMAT IValueGet<D3DFORMAT>.GetValue() => Format;
    readonly object? IValueGet.GetValue() => Format;
}
