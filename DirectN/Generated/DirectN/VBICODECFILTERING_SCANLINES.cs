#nullable enable
namespace DirectN;

public partial struct VBICODECFILTERING_SCANLINES : IValueGet<uint[]>
{
    public InlineArrayUInt32_32 DwordBitArray;
    
    readonly uint[]? IValueGet<uint[]>.GetValue() => ((ReadOnlySpan<uint>)DwordBitArray).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<uint>)DwordBitArray).ToArray();
}
