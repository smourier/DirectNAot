#nullable enable
namespace DirectN;

public partial struct DMUS_OFFSETTABLE : IValueGet<uint[]>
{
    public InlineArrayUInt32_1 ulOffsetTable; // variable-length array placeholder
    
    readonly uint[]? IValueGet<uint[]>.GetValue() => ((ReadOnlySpan<uint>)ulOffsetTable).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<uint>)ulOffsetTable).ToArray();
}
