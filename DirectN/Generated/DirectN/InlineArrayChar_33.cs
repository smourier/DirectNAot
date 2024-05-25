#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_33.Length)]
public partial struct InlineArrayChar_33
{
    public const int Length = 33;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_33>(str, this, Length);
    public static implicit operator InlineArrayChar_33(string? str) { var n = new InlineArrayChar_33(); n.CopyFrom(str); return n; }
}
