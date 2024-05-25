#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_36.Length)]
public partial struct InlineArrayChar_36
{
    public const int Length = 36;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_36>(str, this, Length);
    public static implicit operator InlineArrayChar_36(string? str) { var n = new InlineArrayChar_36(); n.CopyFrom(str); return n; }
}
