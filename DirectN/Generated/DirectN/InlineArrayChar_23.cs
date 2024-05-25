#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_23.Length)]
public partial struct InlineArrayChar_23
{
    public const int Length = 23;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_23>(str, this, Length);
    public static implicit operator InlineArrayChar_23(string? str) { var n = new InlineArrayChar_23(); n.CopyFrom(str); return n; }
}
