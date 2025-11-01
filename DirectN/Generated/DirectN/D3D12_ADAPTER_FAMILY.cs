#nullable enable
namespace DirectN;

public partial struct D3D12_ADAPTER_FAMILY : IValueGet<char[]>
{
    public InlineArraySystemChar_128 szAdapterFamily;
    
    readonly char[]? IValueGet<char[]>.GetValue() => ((ReadOnlySpan<char>)szAdapterFamily).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<char>)szAdapterFamily).ToArray();
}
