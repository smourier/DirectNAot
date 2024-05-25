#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_1.Length)]
public partial struct InlineArraySystemChar_1
{
    public const int Length = 1;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_1>(str, this, Length);
    public static implicit operator InlineArraySystemChar_1(string? str) { var n = new InlineArraySystemChar_1(); n.CopyFrom(str); return n; }
}
