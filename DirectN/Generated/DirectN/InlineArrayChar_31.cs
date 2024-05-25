#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_31.Length)]
public partial struct InlineArrayChar_31
{
    public const int Length = 31;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_31>(str, this, Length);
    public static implicit operator InlineArrayChar_31(string? str) { var n = new InlineArrayChar_31(); n.CopyFrom(str); return n; }
}
