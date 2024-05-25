#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_43.Length)]
public partial struct InlineArrayChar_43
{
    public const int Length = 43;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_43>(str, this, Length);
    public static implicit operator InlineArrayChar_43(string? str) { var n = new InlineArrayChar_43(); n.CopyFrom(str); return n; }
}
