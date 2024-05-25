#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_18.Length)]
public partial struct InlineArrayChar_18
{
    public const int Length = 18;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_18>(str, this, Length);
    public static implicit operator InlineArrayChar_18(string? str) { var n = new InlineArrayChar_18(); n.CopyFrom(str); return n; }
}
