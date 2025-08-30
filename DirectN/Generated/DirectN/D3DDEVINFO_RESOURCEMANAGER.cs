#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-resourcemanager
public partial struct D3DDEVINFO_RESOURCEMANAGER : IValueGet<D3DRESOURCESTATS[]>
{
    public InlineArrayD3DRESOURCESTATS_8 stats;
    
    readonly D3DRESOURCESTATS[]? IValueGet<D3DRESOURCESTATS[]>.GetValue() => ((ReadOnlySpan<D3DRESOURCESTATS>)stats).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<D3DRESOURCESTATS>)stats).ToArray();
}
