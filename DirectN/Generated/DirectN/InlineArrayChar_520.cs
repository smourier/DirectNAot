#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_520.Length)]
public partial struct InlineArrayChar_520
{
    public const int Length = 520;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_520>(str, this, Length);
    public static implicit operator InlineArrayChar_520(string? str) { var n = new InlineArrayChar_520(); n.CopyFrom(str); return n; }
}
