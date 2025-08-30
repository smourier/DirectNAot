#nullable enable
namespace DirectN;

public partial struct D3D12_PROGRAM_IDENTIFIER : IValueGet<ulong[]>
{
    public InlineArrayUInt64_4 OpaqueData;
    
    readonly ulong[]? IValueGet<ulong[]>.GetValue() => ((ReadOnlySpan<ulong>)OpaqueData).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<ulong>)OpaqueData).ToArray();
}
