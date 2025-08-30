#nullable enable
namespace DirectN;

public partial struct BDA_TS_SELECTORINFO_ISDBS_EXT : IValueGet<byte[]>
{
    public InlineArrayByte_48 bTMCC;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)bTMCC).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)bTMCC).ToArray();
}
