#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_17.Length)]
public partial struct InlineArrayChar_17
{
    public const int Length = 17;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_17>(str, this, Length);
    public static implicit operator InlineArrayChar_17(string? str) { var n = new InlineArrayChar_17(); n.CopyFrom(str); return n; }
}
