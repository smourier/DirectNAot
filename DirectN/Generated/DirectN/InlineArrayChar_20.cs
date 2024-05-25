#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_20.Length)]
public partial struct InlineArrayChar_20
{
    public const int Length = 20;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_20>(str, this, Length);
    public static implicit operator InlineArrayChar_20(string? str) { var n = new InlineArrayChar_20(); n.CopyFrom(str); return n; }
}
