#nullable enable
namespace DirectN;

[InlineArray(InlineArrayChar_2550.Length)]
public partial struct InlineArrayChar_2550
{
    public const int Length = 2550;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_2550>(str, this, Length);
    public static implicit operator InlineArrayChar_2550(string? str) { var n = new InlineArrayChar_2550(); n.CopyFrom(str); return n; }
}
