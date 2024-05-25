#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_15.Length)]
public partial struct InlineArrayChar_15
{
    public const int Length = 15;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_15>(str, this, Length);
    public static implicit operator InlineArrayChar_15(string? str) { var n = new InlineArrayChar_15(); n.CopyFrom(str); return n; }
}
