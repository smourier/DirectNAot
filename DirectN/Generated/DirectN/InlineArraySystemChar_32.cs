#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_32.Length)]
public partial struct InlineArraySystemChar_32
{
    public const int Length = 32;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_32>(str, this, Length);
    public static implicit operator InlineArraySystemChar_32(string? str) { var n = new InlineArraySystemChar_32(); n.CopyFrom(str); return n; }
}
