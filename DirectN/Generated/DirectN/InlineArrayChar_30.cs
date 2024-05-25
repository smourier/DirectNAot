#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_30.Length)]
public partial struct InlineArrayChar_30
{
    public const int Length = 30;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_30>(str, this, Length);
    public static implicit operator InlineArrayChar_30(string? str) { var n = new InlineArrayChar_30(); n.CopyFrom(str); return n; }
}
