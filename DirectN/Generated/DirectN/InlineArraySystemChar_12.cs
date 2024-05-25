#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_12.Length)]
public partial struct InlineArraySystemChar_12
{
    public const int Length = 12;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_12>(str, this, Length);
    public static implicit operator InlineArraySystemChar_12(string? str) { var n = new InlineArraySystemChar_12(); n.CopyFrom(str); return n; }
}
