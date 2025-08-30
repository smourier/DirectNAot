#nullable enable
namespace DirectN;

public partial struct VBICODECFILTERING_NABTS_SUBSTREAMS : IValueGet<uint[]>
{
    public InlineArrayUInt32_128 SubstreamMask;
    
    readonly uint[]? IValueGet<uint[]>.GetValue() => ((ReadOnlySpan<uint>)SubstreamMask).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<uint>)SubstreamMask).ToArray();
}
