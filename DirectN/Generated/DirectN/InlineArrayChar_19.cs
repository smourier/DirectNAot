#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_19.Length)]
public partial struct InlineArrayChar_19
{
    public const int Length = 19;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_19>(str, this, Length);
    public static implicit operator InlineArrayChar_19(string? str) { var n = new InlineArrayChar_19(); n.CopyFrom(str); return n; }
}
