#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_24.Length)]
public partial struct InlineArrayChar_24
{
    public const int Length = 24;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_24>(str, this, Length);
    public static implicit operator InlineArrayChar_24(string? str) { var n = new InlineArrayChar_24(); n.CopyFrom(str); return n; }
}
