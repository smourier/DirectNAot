#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_26.Length)]
public partial struct InlineArrayChar_26
{
    public const int Length = 26;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_26>(str, this, Length);
    public static implicit operator InlineArrayChar_26(string? str) { var n = new InlineArrayChar_26(); n.CopyFrom(str); return n; }
}
