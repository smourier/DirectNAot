#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_13.Length)]
public partial struct InlineArrayChar_13
{
    public const int Length = 13;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_13>(str, this, Length);
    public static implicit operator InlineArrayChar_13(string? str) { var n = new InlineArrayChar_13(); n.CopyFrom(str); return n; }
}
