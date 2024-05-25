#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_128.Length)]
public partial struct InlineArraySystemChar_128
{
    public const int Length = 128;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_128>(str, this, Length);
    public static implicit operator InlineArraySystemChar_128(string? str) { var n = new InlineArraySystemChar_128(); n.CopyFrom(str); return n; }
}
