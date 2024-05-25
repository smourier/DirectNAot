#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_64.Length)]
public partial struct InlineArraySystemChar_64
{
    public const int Length = 64;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_64>(str, this, Length);
    public static implicit operator InlineArraySystemChar_64(string? str) { var n = new InlineArraySystemChar_64(); n.CopyFrom(str); return n; }
}
