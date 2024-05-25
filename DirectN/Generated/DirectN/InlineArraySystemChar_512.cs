#nullable enable
namespace DirectN;

[InlineArray(InlineArraySystemChar_512.Length)]
public partial struct InlineArraySystemChar_512
{
    public const int Length = 512;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArraySystemChar_512>(str, this, Length);
    public static implicit operator InlineArraySystemChar_512(string? str) { var n = new InlineArraySystemChar_512(); n.CopyFrom(str); return n; }
}
