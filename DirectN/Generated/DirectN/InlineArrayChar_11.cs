#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_11.Length)]
public partial struct InlineArrayChar_11
{
    public const int Length = 11;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_11>(str, this, Length);
    public static implicit operator InlineArrayChar_11(string? str) { var n = new InlineArrayChar_11(); n.CopyFrom(str); return n; }
}
