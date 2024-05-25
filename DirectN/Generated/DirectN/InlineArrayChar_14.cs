#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_14.Length)]
public partial struct InlineArrayChar_14
{
    public const int Length = 14;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_14>(str, this, Length);
    public static implicit operator InlineArrayChar_14(string? str) { var n = new InlineArrayChar_14(); n.CopyFrom(str); return n; }
}
