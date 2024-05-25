#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_10.Length)]
public partial struct InlineArrayChar_10
{
    public const int Length = 10;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_10>(str, this, Length);
    public static implicit operator InlineArrayChar_10(string? str) { var n = new InlineArrayChar_10(); n.CopyFrom(str); return n; }
}
