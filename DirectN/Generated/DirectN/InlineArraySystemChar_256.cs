#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_256.Length)]
public partial struct InlineArraySystemChar_256
{
    public const int Length = 256;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_256>(str, this, Length);
    public static implicit operator InlineArraySystemChar_256(string? str) { var n = new InlineArraySystemChar_256(); n.CopyFrom(str); return n; }
}
