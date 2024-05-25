#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_21.Length)]
public partial struct InlineArrayChar_21
{
    public const int Length = 21;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_21>(str, this, Length);
    public static implicit operator InlineArrayChar_21(string? str) { var n = new InlineArrayChar_21(); n.CopyFrom(str); return n; }
}
