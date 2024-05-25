#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_22.Length)]
public partial struct InlineArrayChar_22
{
    public const int Length = 22;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_22>(str, this, Length);
    public static implicit operator InlineArrayChar_22(string? str) { var n = new InlineArrayChar_22(); n.CopyFrom(str); return n; }
}
