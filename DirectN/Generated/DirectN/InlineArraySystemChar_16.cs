#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_16.Length)]
public partial struct InlineArraySystemChar_16
{
    public const int Length = 16;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_16>(str, this, Length);
    public static implicit operator InlineArraySystemChar_16(string? str) { var n = new InlineArraySystemChar_16(); n.CopyFrom(str); return n; }
}
